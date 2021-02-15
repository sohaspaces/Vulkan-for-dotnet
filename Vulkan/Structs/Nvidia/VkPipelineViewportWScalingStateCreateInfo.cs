

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineViewportWScalingStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 ViewportWScalingEnable { get; init; }

        public uint ViewportCount { get; init; }

        public unsafe VkViewportWScaling* ViewportWScalings { get; init; }
    }
}
