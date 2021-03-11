using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan.Structs.Extension;
using Vulkan.Structs;
using Vulkan.Enums;
using Vulkan;
using Vulkan.Handles;


namespace VulkanManaged.QueueOperations
{
    public sealed class SubmitOperation
    {
        public sealed record Info
        {
            public IEnumerable<INext<VkSubmitInfo>> Nexts { get; init; } = Enumerable.Empty<INext<VkSubmitInfo>>();
        }
    }
}
