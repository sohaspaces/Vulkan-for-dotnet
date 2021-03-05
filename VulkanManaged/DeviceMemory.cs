using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan.Handles;
using Vulkan;
using Vulkan.Structs;
using Vulkan.Enums;

namespace VulkanManaged
{
    public sealed class DeviceMemory : IDisposable
    {

        #region Info

        public sealed record Info
        {
            public LogicalDevice Device { get; init; }

            public VkDeviceSize Size { get; init; }
            public uint MemoryTypeIndex { get; init; }

            public IEnumerable<INext<VkMemoryAllocateInfo>> Nexts = Enumerable.Empty<INext<VkMemoryAllocateInfo>>();
        }

        #endregion

        #region Instance Members

        /// <summary>
        /// The unmanaged handle of the command queue.
        /// </summary>
        public VkDeviceMemory MemoryHandle { get; private init; }

        /// <summary>
        /// The logical device by which the <see cref="DeviceMemory"/> instance was created.
        /// </summary>
        public LogicalDevice Device { get; private init; }

        #endregion

        #region Constructors

        public unsafe DeviceMemory(Info info)
        {
            var allocInfo = new VkMemoryAllocateInfo
            {
                 StructureType = VkStructureType.MemoryAllocateInfo,
                 
                 AllocationSize = info.Size,
                 MemoryTypeIndex = info.MemoryTypeIndex,
                 
                 Next = info.Nexts.MakeChain()
            };

            Vk.AllocateMemory(info.Device.DeviceHandle, ref allocInfo, (VkAllocationCallbacks[])null, out var handle);
            MemoryHandle = handle;
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
                Vk.FreeMemory(Device.DeviceHandle, MemoryHandle, (VkAllocationCallbacks[])null);
                disposedValue = true;
            }
        }

        ~DeviceMemory()
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
