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
    public sealed class FenceSync : IDisposable
    {

        #region Info

        public sealed record Info
        {

            /// <summary>
            /// The <c>pNext</c> chain components for <see cref="VkFenceCreateInfo"/>.
            /// </summary>
            /// <seealso cref="INext{TAbout}"/>
            public IEnumerable<INext<VkFenceCreateInfo>> Nexts { get; init; } = Enumerable.Empty<INext<VkFenceCreateInfo>>();

            public VkFenceCreateFlags Flags { get; init; }

            public LogicalDevice Device { get; init; }

        }

        #endregion

        #region Instance Members

        public VkFence FenceHandle { get; private init; }

        public LogicalDevice Device { get; private init; }

        public bool IsSignaled
            => Vk.GetFenceStatus(Device.DeviceHandle, FenceHandle) == VkResult.Success;

        #endregion

        #region Constructors

        public unsafe FenceSync(Info info)
        {
            var createInfo = new VkFenceCreateInfo()
            {
                StructureType = VkStructureType.FenceCreateInfo,
                
                Flags = info.Flags,

                Next = info.Nexts.MakeChain()
            };

            Vk.CreateFence(info.Device.DeviceHandle, ref createInfo, null, out var handle);
            FenceHandle = handle;
            Device = info.Device;
        }

        #endregion

        #region Destructors

        private bool disposedValue;

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                Vk.DestroyFence(Device.DeviceHandle, FenceHandle, (VkAllocationCallbacks[])null);
                disposedValue = true;
                GC.KeepAlive(Device);
            }
        }

        ~FenceSync()
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
