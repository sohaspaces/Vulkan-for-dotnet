

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineDiscardRectangleStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineDiscardRectangleStateCreateFlags Flags { get; init; }

        public VkDiscardRectangleMode DiscardRectangleMode { get; init; }

        public uint DiscardRectangleCount { get; init; }

        public unsafe VkRect2D* DiscardRectangles { get; init; }
    }
}
