

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorSetLayoutBindingFlagsCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint BindingCount { get; init; }

        public unsafe VkDescriptorBindingFlags* BindingFlags { get; init; }
    }
}
