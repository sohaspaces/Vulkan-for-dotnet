using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using Vulkan.Handles;
using Vulkan.Structs;
using Vulkan.Enums;

namespace VulkanManaged
{
    public sealed class DeviceBuffer : IDisposable
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
            /// The size of the buffer.
            /// </summary>
            public VkDeviceSize Size { get; init; }

            /// <summary>
            /// The flags for <see cref="VkBufferCreateInfo"/>.
            /// </summary>
            public VkBufferCreateFlags Flags { get; init; }

            /// <summary>
            /// The usage of the buffer.
            /// </summary>
            public VkBufferUsageFlags Usage { get; init; }

            /// <summary>
            /// The information about sharing the buffer with one or more queues.
            /// </summary>
            public VkSharingMode SharingMode { get; init; }

            /// <summary>
            /// The queue families which can access the buffer.
            /// It doesn't matter if <see cref="SharingMode"/> is <see cref="VkSharingMode.Concurrent"/>.
            /// </summary>
            public IEnumerable<uint> QueueFamilies { get; init; } = Enumerable.Empty<uint>();

            /// <summary>
            /// The <c>pNext</c> chain components for <see cref="VkBufferCreateInfo"/>.
            /// </summary>
            /// <seealso cref="INext{TAbout}"/>
            public IEnumerable<INext<VkBufferCreateInfo>> Nexts { get; init; } = Enumerable.Empty<INext<VkBufferCreateInfo>>();

        }

        #endregion

        #region Instance Members

        /// <summary>
        /// The unmanaged handle of the buffer.
        /// </summary>
        public VkBuffer BufferHandle { get; private init; }

        /// <summary>
        /// The device where the buffer exists.
        /// </summary>
        public LogicalDevice Device { get; private init; }

        #endregion

        #region Constructors

        public unsafe DeviceBuffer(Info info)
        {
            var familyData = info.QueueFamilies.ToArray();

            var createInfo = new VkBufferCreateInfo()
            {
                StructureType = VkStructureType.BufferCreateInfo,

                Flags = info.Flags,

                Size = info.Size,

                QueueFamilyIndexCount = (uint)familyData.Length,
                QueueFamilyIndices = familyData.Pin(),

                SharingMode = info.SharingMode,
                Usage = info.Usage,

                Next = info.Nexts.MakeChain()
            };

            Vk.CreateBuffer(info.Device.DeviceHandle, ref createInfo, (VkAllocationCallbacks[])null, out var handle);
            BufferHandle = handle;
            Device = info.Device;
        }

        #endregion

        #region Destructors

        private bool disposedValue;

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                Vk.DestroyBuffer(Device.DeviceHandle, BufferHandle, (VkAllocationCallbacks[])null);
                disposedValue = true;
                GC.KeepAlive(Device);
            }
        }

        ~DeviceBuffer()
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
