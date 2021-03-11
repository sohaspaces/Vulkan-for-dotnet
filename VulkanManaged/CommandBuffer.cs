using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using Vulkan.Enums;
using Vulkan.Handles;
using Vulkan.Structs;
using VulkanManaged.BufferOperations;

namespace VulkanManaged
{
    public sealed class CommandBuffer : IDisposable
    {
        /// <summary>
        /// Information for creating a <see cref="CommandPool"/> instance.
        /// </summary>
        public sealed record Info
        {
            /// <summary>
            /// A command pool where the command buffer will be created.
            /// </summary>
            public CommandPool Pool { get; init; }
            
            /// <summary>
            /// Whether the command buffer can be nested in another command buffer.
            /// More explicitly, Whether to set the level <see cref="VkCommandBufferLevel.Secondary"/>.
            /// </summary>
            public bool IsNested { get; init; }

            /// <summary>
            /// The <c>pNext</c> chain components for <see cref="VkCommandBufferAllocateInfo"/>.
            /// </summary>
            /// <seealso cref="INext{TAbout}"/>
            public IEnumerable<INext<VkCommandBufferAllocateInfo>> Nexts { get; init; } = Enumerable.Empty<INext<VkCommandBufferAllocateInfo>>();

        }

        public sealed record EncodeInfo
        {
            public VkCommandBufferUsageFlags Usage { get; init; }

            /// <summary>
            /// The operations to encode. They are in an array because their order must be preserved. It will start from the zero-indexed element.
            /// </summary>
            public IBufferOperation[] Operations { get; init; } = Array.Empty<IBufferOperation>();

            /// <summary>
            /// The <c>pNext</c> chain components for <see cref="VkCommandBufferBeginInfo"/>.
            /// </summary>
            /// <seealso cref="INext{TAbout}"/>
            public IEnumerable<INext<VkCommandBufferAllocateInfo>> Nexts { get; init; } = Enumerable.Empty<INext<VkCommandBufferAllocateInfo>>();
        }

        
        public sealed record InheritanceInfo : Wrap<VkCommandBufferInheritanceInfo>
        {
            public InheritanceInfo(VkCommandBufferInheritanceInfo x) : base(x)
            {
                throw new NotImplementedException();
            }

            public override VkCommandBufferInheritanceInfo Unwrap()
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// The command pool where the command buffer exists.
        /// </summary>
        public CommandPool Pool { get; init; }

        /// <summary>
        /// The unmanaged handle of the command buffer.
        /// </summary>
        public VkCommandBuffer BufferHandle { get; init; }

        public unsafe CommandBuffer(Info info)
        {
            if (info.IsNested)
                throw new NotImplementedException(ExceptionMessages.SecondaryNotSupported);
            var allocInfo = new VkCommandBufferAllocateInfo()
            {
                StructureType = VkStructureType.CommandBufferAllocateInfo,
                CommandBufferCount = 1,
                CommandPool = info.Pool.PoolHandle,
                Level = VkCommandBufferLevel.Secondary,
                Next = info.Nexts.MakeChain()
            };
            Vk.AllocateCommandBuffers(info.Pool.Device.DeviceHandle, ref allocInfo, out var handle);
            Pool = info.Pool;
            BufferHandle = handle;
        }

        public void Encode(EncodeInfo info)
        {
            var handle = BufferHandle;
            unsafe
            {
                var beginInfo = new VkCommandBufferBeginInfo()
                {
                    StructureType = VkStructureType.CommandBufferBeginInfo,
                    Flags = info.Usage,

                    Next = info.Nexts.MakeChain(),
                    InheritanceInfo = null
                };
                Vk.BeginCommandBuffer(handle, ref beginInfo);
            }
            var data = info.Operations;
            var length = data.Length;
            for (int i = 0; i < length; i++)
                data[i].EncodeTo(handle);
            Vk.EndCommandBuffer(handle);
        }

        #region Destructors

        private bool disposedValue;

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {

                disposedValue = true;
            }
        }

        ~CommandBuffer()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
