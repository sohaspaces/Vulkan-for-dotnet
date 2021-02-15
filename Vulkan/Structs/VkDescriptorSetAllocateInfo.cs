

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorSetAllocateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDescriptorPool DescriptorPool { get; init; }

        public uint DescriptorSetCount { get; init; }

        public unsafe VkDescriptorSetLayout* SetLayouts { get; init; }
    }
}
