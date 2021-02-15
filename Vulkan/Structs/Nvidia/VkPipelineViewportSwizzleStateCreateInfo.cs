

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineViewportSwizzleStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineViewportSwizzleStateCreateFlags Flags { get; init; }

        public uint ViewportCount { get; init; }

        public unsafe VkViewportSwizzle* ViewportSwizzles { get; init; }
    }
}
