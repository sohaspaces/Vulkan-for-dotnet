

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineDynamicStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineDynamicStateCreateFlags Flags { get; init; }

        public uint DynamicStateCount { get; init; }

        public unsafe VkDynamicState* DynamicStates { get; init; }
    }
}
