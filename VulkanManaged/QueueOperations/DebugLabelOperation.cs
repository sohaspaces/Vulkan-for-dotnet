using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan.Handles;
using Vulkan.Structs.Extension;
using Vulkan.Enums;
using Vulkan;
using System.Numerics;

namespace VulkanManaged.QueueOperations
{
    public abstract class DebugLabelOperation : IQueueOperation
    {
        public sealed record Info
        {
            public string LabelName { get; init; }
            public Vector4 Color { get; init; }
            public IEnumerable<INext<VkDebugUtilsLabel>> Nexts { get; init; } = Enumerable.Empty<INext<VkDebugUtilsLabel>>();
        }

        private VkDebugUtilsLabel label;

        public unsafe DebugLabelOperation(Info info)
        {
            label = new VkDebugUtilsLabel()
            {
                StructureType = VkStructureType.DebugUtilsLabelExt,

                Color = (info.Color.X, info.Color.Y, info.Color.Z, info.Color.W),
                LabelName = info.LabelName.Pin(Encoding.UTF8),

                Next = info.Nexts.MakeChain()
            };
        }

        void IQueueOperation.EnqueueTo(VkQueue handle)
            => EnqueueTo(handle, label);

        protected abstract void EnqueueTo(VkQueue handle, VkDebugUtilsLabel label);
    }
}
