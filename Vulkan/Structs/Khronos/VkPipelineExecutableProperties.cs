using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineExecutableProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkShaderStageFlags Stages { get; init; }

        public UnmanagedString256 Name { get; init; }
        public UnmanagedString256 Description { get; init; }

        public uint SubgroupSize { get; init; }
    }
}
