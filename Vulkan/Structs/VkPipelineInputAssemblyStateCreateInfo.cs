

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineInputAssemblyStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineInputAssemblyStateCreateFlags Flags { get; init; }

        public VkPrimitiveTopology Topology { get; init; }

        public VkBool32 PrimitiveRestartEnable { get; init; }
    }
}
