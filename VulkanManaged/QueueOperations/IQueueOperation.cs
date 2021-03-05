using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan.Handles;

namespace VulkanManaged.QueueOperations
{
    /// <summary>
    /// Represents a queue operation.
    /// </summary>
    public interface IQueueOperation
    {
        protected internal void EnqueueTo(VkQueue handle);
    }
}
