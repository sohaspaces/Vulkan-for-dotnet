using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using Vulkan.Handles;
using Vulkan.Structs.Extension;

namespace VulkanManaged.QueueOperations
{
    public sealed class InsertDebugLabelOperation : DebugLabelOperation
    {
        public InsertDebugLabelOperation(Info info) : base(info)
        {
        }

        protected override void EnqueueTo(VkQueue handle, VkDebugUtilsLabel label)
            => VkExt.QueueInsertDebugUtilsLabel(handle, ref label);
    }
}
