using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using Vulkan.Handles;

namespace VulkanManaged.QueueOperations
{
    public sealed class EndDebugLabelOperation : IQueueOperation
    {
        void IQueueOperation.EnqueueTo(VkQueue handle)
            => VkExt.QueueEndDebugUtilsLabel(handle);
    }
}
