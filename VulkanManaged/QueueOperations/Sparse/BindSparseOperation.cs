using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using Vulkan.Structs;
using Vulkan.Enums;
using Xystem.Numerics;
using Vulkan.Handles;

namespace VulkanManaged.QueueOperations.Sparse
{
    public sealed record MemoryBind
    {
        public VkDeviceSize ResourceOffset { get; init; }
        public VkDeviceSize Size { get; init; }

        public DeviceMemory Memory { get; init; }
        public VkDeviceSize MemoryOffset { get; init; }

        public VkSparseMemoryBindFlags Flags { get; init; }

        internal VkSparseMemoryBind Native => new VkSparseMemoryBind
        {
            Flags = Flags,
            Memory = Memory.MemoryHandle,
            MemoryOffset = MemoryOffset,
            ResourceOffset = ResourceOffset,
            Size = Size
        };
    }

    public sealed record BufferBindInfo
    {
        public DeviceBuffer Buffer { get; init; }

        public IEnumerable<MemoryBind> Binds { get; init; } = Enumerable.Empty<MemoryBind>();
    }

    public sealed record ImageOpaqueBindInfo
    {
        public DeviceImage Image { get; init; }

        public IEnumerable<MemoryBind> Binds { get; init; } = Enumerable.Empty<MemoryBind>();

    }

    public sealed record ImageBind
    {
        public DeviceImage.Subresource Subresource { get; init; }

        public Vector3Int Offset { get; init; }
        public Vector3UInt Extent { get; init; }

        public DeviceMemory Memory { get; init; }
        public VkDeviceSize MemoryOffset { get; init; }

        public VkSparseMemoryBindFlags Flags { get; init; }

        internal VkSparseImageMemoryBind Native => new VkSparseImageMemoryBind
        {
            Extent = new VkExtent3D
            {
                Width = Extent.X,
                Height = Extent.Y,
                Depth = Extent.Z
            },
            Offset = new VkOffset3D
            {
                X = Offset.X,
                Y = Offset.Y,
                Z = Offset.Z
            },
            Flags = Flags,
            Memory = Memory.MemoryHandle,
            MemoryOffset = MemoryOffset,
            Subresource = Subresource.Unwrap()
        };
    }

    public sealed record ImageBindInfo
    {
        public DeviceImage Image { get; init; }

        public IEnumerable<ImageBind> Binds { get; init; } = Enumerable.Empty<ImageBind>();
    }

    public sealed record BindSparse
    {
        public IEnumerable<SemaphoreSync> SignalSemaphores { get; init; } = Enumerable.Empty<SemaphoreSync>();
        public IEnumerable<SemaphoreSync> WaitSemaphores { get; init; } = Enumerable.Empty<SemaphoreSync>();

        public IEnumerable<BufferBindInfo> BufferBinds { get; init; } = Enumerable.Empty<BufferBindInfo>();
        public IEnumerable<ImageOpaqueBindInfo> ImageOpaqueBinds { get; init; } = Enumerable.Empty<ImageOpaqueBindInfo>();
        public IEnumerable<ImageBindInfo> ImageBinds { get; init; } = Enumerable.Empty<ImageBindInfo>();

        public IEnumerable<INext<VkBindSparseInfo>> Nexts { get; init; } = Enumerable.Empty<INext<VkBindSparseInfo>>();
    }


    public sealed unsafe class BindSparseOperation : IQueueOperation
    {
        public sealed record Info
        {
            public IEnumerable<BindSparse> Sparses { get; init; } = Enumerable.Empty<BindSparse>();
            public FenceSync Fence { get; init; }
        }

        private uint sz;
        private VkBindSparseInfo* ptr;
        private FenceSync fence;

        public BindSparseOperation(Info info)
        {
            var sparseData = info.Sparses.ToArray();
            var count = sparseData.Length;
            var infos = new VkBindSparseInfo[count];

            for (int i = 0; i < count; i++)

            {
                var sparseInfo = sparseData[i];

                var bufferData =
                (
                    from bindInfo in sparseInfo.BufferBinds
                    let bindData = (from bind in bindInfo.Binds select bind.Native).ToArray()
                    select new VkSparseBufferMemoryBindInfo
                    {
                        Buffer = bindInfo.Buffer.BufferHandle,
                        BindCount = (uint)bindData.Length,
                        Binds = bindData.Pin()
                    }
                )
                .ToArray();

                var imageOpaqueData =
                (
                    from bindInfo in sparseInfo.ImageOpaqueBinds
                    let bindData = (from bind in bindInfo.Binds select bind.Native).ToArray()
                    select new VkSparseImageOpaqueMemoryBindInfo
                    {
                        Image = bindInfo.Image.ImageHandle,
                        BindCount = (uint)bindData.Length,
                        Binds = bindData.Pin()
                    }
                )
                .ToArray();

                var imageData =
                (
                    from bindInfo in sparseInfo.ImageBinds
                    let bindData = (from bind in bindInfo.Binds select bind.Native).ToArray()
                    select new VkSparseImageMemoryBindInfo
                    {
                        Image = bindInfo.Image.ImageHandle,
                        BindCount = (uint)bindData.Length,
                        Binds = bindData.Pin()
                    }
                )
                .ToArray();

                var signalData = (from sync in sparseInfo.SignalSemaphores select sync.SemaphoreHandle).ToArray();
                var waitData = (from sync in sparseInfo.WaitSemaphores select sync.SemaphoreHandle).ToArray();

                infos[i] = new VkBindSparseInfo()
                {
                    StructureType = VkStructureType.BindSparseInfo,

                    BufferBindCount = (uint)bufferData.Length,
                    BufferBinds = bufferData.Pin(),

                    ImageOpaqueBindCount = (uint)imageOpaqueData.Length,
                    ImageOpaqueBinds = imageOpaqueData.Pin(),

                    ImageBindCount = (uint)imageData.Length,
                    ImageBinds = imageData.Pin(),

                    SignalSemaphoreCount = (uint)signalData.Length,
                    SignalSemaphores = signalData.Pin(),

                    WaitSemaphoreCount = (uint)waitData.Length,
                    WaitSemaphores = waitData.Pin(),

                    Next = sparseInfo.Nexts.MakeChain()
                };
            }
            sz = (uint)count;
            ptr = infos.Pin();
            fence = info.Fence;
        }

        void IQueueOperation.EnqueueTo(VkQueue handle)
            => Vk.QueueBindSparse(handle, sz, ptr, fence.FenceHandle);
    }
}
