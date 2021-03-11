using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan.Handles;

namespace VulkanManaged.BufferOperations
{
    public interface IBufferOperation
    {
        protected internal void EncodeTo(VkCommandBuffer handle);
    }
}
