

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineViewportExclusiveScissorStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint ExclusiveScissorCount { get; init; }

        public unsafe VkRect2D* ExclusiveScissors { get; init; }
    }
}
