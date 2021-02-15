

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorSetVariableDescriptorCountAllocateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint DescriptorSetCount { get; init; }

        public unsafe uint* DescriptorCounts { get; init; }
    }
}
