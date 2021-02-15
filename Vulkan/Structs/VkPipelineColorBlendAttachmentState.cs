

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineColorBlendAttachmentState
    {
        public VkBool32 BlendEnable { get; init; }

        public VkBlendFactor SrcColorBlendFactor { get; init; }

        public VkBlendFactor DstColorBlendFactor { get; init; }

        public VkBlendOp ColorBlendOp { get; init; }

        public VkBlendFactor SrcAlphaBlendFactor { get; init; }

        public VkBlendFactor DstAlphaBlendFactor { get; init; }

        public VkBlendOp AlphaBlendOp { get; init; }

        public VkColorComponentFlags ColorWriteMask { get; init; }
    }
}
