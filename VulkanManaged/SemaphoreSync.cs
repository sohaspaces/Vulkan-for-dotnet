using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using Vulkan.Enums;
using Vulkan.Handles;
using Vulkan.Structs;

namespace VulkanManaged
{
    public sealed class SemaphoreSync : IDisposable
    {

        #region Info

        public sealed record Info
        {

            /// <summary>
            /// The <c>pNext</c> chain components for <see cref="VkSemaphoreCreateInfo"/>.
            /// </summary>
            /// <seealso cref="INext{TAbout}"/>
            public IEnumerable<INext<VkSamplerCreateInfo>> Nexts { get; init; } = Enumerable.Empty<INext<VkSamplerCreateInfo>>();

            public VkSemaphoreCreateFlags Flags { get; init; }

            public LogicalDevice Device { get; init; }

        }

        #endregion

        #region Instance Members

        public VkSemaphore SemaphoreHandle { get; private init; }

        public LogicalDevice Device { get; private init; }

        #endregion

        #region Constructors

        public unsafe SemaphoreSync(Info info)
        {
            var createInfo = new VkSemaphoreCreateInfo()
            {
                StructureType = VkStructureType.SemaphoreCreateInfo,
                
                Flags = info.Flags,
                
                Next = info.Nexts.MakeChain()
            };

            Vk.CreateSemaphore(info.Device.DeviceHandle, ref createInfo, null, out var handle);
            SemaphoreHandle = handle;
            Device = info.Device;
        }

        #endregion

        #region Destructors

        private bool disposedValue;

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                Vk.DestroySemaphore(Device.DeviceHandle, SemaphoreHandle, (VkAllocationCallbacks[])null);
                disposedValue = true;
            }
        }

        ~SemaphoreSync()
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
