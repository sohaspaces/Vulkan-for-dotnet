using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xystem.Numerics;
using Vulkan;
using Vulkan.Enums;
using Vulkan.Handles;
using Vulkan.Structs;

namespace VulkanManaged
{
    public sealed class DeviceImage : IDisposable
    {

        #region Info

        /// <summary>
        /// Information for creating a <see cref="DeviceBuffer"/> instance.
        /// </summary>
        public sealed record Info
        {

            /// <summary>
            /// The device where the buffer will be created.
            /// </summary>
            public LogicalDevice Device { get; init; }

            /// <summary>
            /// The flags for <see cref="VkImageCreateInfo"/>.
            /// </summary>
            public VkImageCreateFlags Flags { get; init; }

            /// <summary>
            /// The count of the layers in the image.
            /// </summary>
            public uint LayerCount { get; init; }

            /// <summary>
            /// The extent of the image.
            /// If you want to make it 2d, set the Z value as 1.
            /// In case of 1d, set both Y and Z value as 1.
            /// </summary>
            public Vector3UInt Extent { get; init; }
            
            /// <summary>
            /// The format of the image.
            /// </summary>
            public VkFormat Format { get; init; }

            /// <summary>
            /// The type of the image.
            /// </summary>
            public VkImageType ImageType { get; init; }

            /// <summary>
            /// The initial layout of the image.
            /// </summary>
            public VkImageLayout Layout { get; init; }

            /// <summary>
            /// The mip levels of the image.
            /// </summary>
            public uint MipLevels { get; init; }

            /// <summary>
            /// The queue families which can access the buffer.
            /// It doesn't matter if <see cref="SharingMode"/> is <see cref="VkSharingMode.Concurrent"/>.
            /// </summary>
            public IEnumerable<uint> QueueFamilies { get; init; } = Enumerable.Empty<uint>();

            private uint samplesCount;

            /// <summary>
            /// The count of each texel.
            /// It must be 2^<c>n</c> which is less than 65, where <c>n</c> is an integer.
            /// </summary>
            public uint SamplesCount 
            { 
                get => samplesCount;
                init
                {
                    if ((value & 0x0000007F) == 0)
                        throw new ArgumentOutOfRangeException(nameof(value));

                    uint count = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        count += (value >> i) & 1;
                        if(count > 1)
                            throw new ArgumentOutOfRangeException(nameof(value));
                    }
                    samplesCount = value;
                }
            }

            /// <summary>
            /// The information about sharing the buffer with one or more queues.
            /// </summary>
            public VkSharingMode SharingMode { get; init; }

            /// <summary>
            /// The tiling of the image.
            /// </summary>
            public VkImageTiling Tiling { get; init; }

            /// <summary>
            /// The usage of the image.
            /// </summary>
            public VkImageUsageFlags Usage { get; init; }

            /// <summary>
            /// The <c>pNext</c> chain components for <see cref="VkBufferCreateInfo"/>.
            /// </summary>
            /// <seealso cref="INext{TAbout}"/>
            public IEnumerable<INext<VkImageCreateInfo>> Nexts { get; init; } = Enumerable.Empty<INext<VkImageCreateInfo>>();
        }

        #endregion

        #region Instance Members

        /// <summary>
        /// The unmanaged handle of the buffer.
        /// </summary>
        public VkImage ImageHandle { get; private init; }

        /// <summary>
        /// The device where the buffer exists.
        /// </summary>
        public LogicalDevice Device { get; private init; }

        #endregion

        #region Nested Members

        public sealed record Subresource : Wrap<VkImageSubresource>
        {
            public VkImageAspectFlags AspectMask { get; init; }

            public uint MipLevel { get; init; }
            public uint Layer { get; init; }

            public Subresource(VkImageSubresource x) : base(x)
            {
                AspectMask = x.AspectMask;
                MipLevel = x.MipLevel;
                Layer = x.ArrayLayer;
            }

            public override VkImageSubresource Unwrap()
                => new VkImageSubresource()
                {
                    AspectMask = AspectMask,
                    ArrayLayer = Layer,
                    MipLevel = MipLevel
                };

        }

        #endregion

        #region Constructors

        public unsafe DeviceImage(Info info)
        {
            var familyData = info.QueueFamilies.ToArray();

            var extent = info.Extent;

            var createInfo = new VkImageCreateInfo
            {
                StructureType = VkStructureType.BufferCreateInfo,

                Flags = info.Flags,
                
                ArrayLayers = info.LayerCount,
                
                Extent = new VkExtent3D()
                {
                    Width = extent.X,
                    Height = extent.Y,
                    Depth = extent.Z
                },
                
                Format = info.Format,
                
                ImageType = info.ImageType,
                
                InitialLayout = info.Layout,
                
                MipLevels = info.MipLevels,
                
                QueueFamilyIndexCount = (uint)familyData.Length,
                QueueFamilyIndices = familyData.Pin(),
                
                Samples = (VkSampleCountFlags)info.SamplesCount,
                
                SharingMode = info.SharingMode,
                
                Tiling = info.Tiling,
                Usage = info.Usage,
                
                Next = info.Nexts.MakeChain()
            };

            Vk.CreateImage(info.Device.DeviceHandle, ref createInfo, (VkAllocationCallbacks[])null, out var handle);
            ImageHandle = handle;
            Device = info.Device;
            Device.AddPreviousDisposable(this);
        }

        #endregion

        #region Destructors

        private bool disposedValue;

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                Vk.DestroyImage(Device.DeviceHandle, ImageHandle, (VkAllocationCallbacks[])null);
                disposedValue = true;
            }
        }

        ~DeviceImage()
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
