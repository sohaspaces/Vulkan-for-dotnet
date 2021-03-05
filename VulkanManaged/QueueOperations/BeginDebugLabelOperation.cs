using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Vulkan.Structs.Extension;
using Vulkan.Enums;
using Vulkan;
using Vulkan.Handles;

namespace VulkanManaged.QueueOperations
{
    public sealed class BeginDebugLabelOperation : DebugLabelOperation
    {
        public BeginDebugLabelOperation(Info info) : base(info)
        {
        }

        protected override void EnqueueTo(VkQueue handle, VkDebugUtilsLabel label)
            => VkExt.QueueBeginDebugUtilsLabel(handle, ref label);
    }
}
