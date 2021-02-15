

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineVertexInputStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineVertexInputStateCreateFlags Flags { get; init; }

        public uint VertexBindingDescriptionCount { get; init; }

        public unsafe VkVertexInputBindingDescription* VertexBindingDescriptions { get; init; }

        public uint VertexAttributeDescriptionCount { get; init; }

        public unsafe VkVertexInputAttributeDescription* VertexAttributeDescriptions { get; init; }
    }
}
