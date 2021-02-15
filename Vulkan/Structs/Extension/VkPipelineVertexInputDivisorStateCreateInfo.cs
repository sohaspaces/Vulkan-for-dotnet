

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineVertexInputDivisorStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint VertexBindingDivisorCount { get; init; }

        public unsafe VkVertexInputBindingDivisorDescription* VertexBindingDivisors { get; init; }
    }
}
