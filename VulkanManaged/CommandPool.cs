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
    public sealed class CommandPool : IDisposable
    {
        public sealed record Info
        {
            /// <summary>
            /// Designates a queue family as described in section Queue Family Properties. All command buffers allocated from this command pool must be submitted on queues from the same queue family.
            /// </summary>
            public uint QueueFamilyIndex { get; init; }

            /// <summary>
            /// The flags for <see cref="VkDeviceCreateInfo"/>.
            /// </summary>
            public VkCommandPoolCreateFlags Flags { get; init; }

            /// <summary>
            /// The <c>pNext</c> chain components for <see cref="VkCommandPoolCreateInfo"/>.
            /// </summary>
            /// <seealso cref="INext{TAbout}"/>
            public IEnumerable<INext<VkCommandPoolCreateInfo>> Nexts { get; init; } = Enumerable.Empty<INext<VkCommandPoolCreateInfo>>();

            /// <summary>
            /// The device where the command pool will be created.
            /// </summary>
            public LogicalDevice Device { get; init; }
        }

        /// <summary>
        /// The logical device where the <see cref="CommandPool"/> instance exists.
        /// </summary>
        public LogicalDevice Device { get; init; }

        /// <summary>
        /// The unmanaged handle of the command pool.
        /// </summary>
        public VkCommandPool PoolHandle { get; init; }

        public unsafe CommandPool(Info info)
        {
            var createInfo = new VkCommandPoolCreateInfo()
            {
                StructureType = VkStructureType.CommandPoolCreateInfo,
                Flags = info.Flags,
                Next = info.Nexts.MakeChain(),
                QueueFamilyIndex = info.QueueFamilyIndex
            };
            Vk.CreateCommandPool(info.Device.DeviceHandle, ref createInfo, (VkAllocationCallbacks[])null, out var handle);
            PoolHandle = handle;
            Device = info.Device;
        }

        #region Deconstructors

        private bool disposedValue;

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                Vk.DestroyCommandPool(Device.DeviceHandle, PoolHandle, (VkAllocationCallbacks[])null);
                disposedValue = true;
            }
        }

        ~CommandPool()
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
