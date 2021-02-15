

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineDepthStencilStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineDepthStencilStateCreateFlags Flags { get; init; }

        public VkBool32 DepthTestEnable { get; init; }

        public VkBool32 DepthWriteEnable { get; init; }

        public VkCompareOp DepthCompareOp { get; init; }

        public VkBool32 DepthBoundsTestEnable { get; init; }

        public VkBool32 StencilTestEnable { get; init; }

        public VkStencilOpState Front { get; init; }

        public VkStencilOpState Back { get; init; }

        public float MinDepthBounds { get; init; }

        public float MaxDepthBounds { get; init; }
    }
}
