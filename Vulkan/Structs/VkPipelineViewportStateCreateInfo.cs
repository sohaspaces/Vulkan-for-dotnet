

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineViewportStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineViewportStateCreateFlags Flags { get; init; }

        public uint ViewportCount { get; init; }

        public unsafe VkViewport* Viewports { get; init; }

        public uint ScissorCount { get; init; }

        public unsafe VkRect2D* Scissors { get; init; }
    }
}
