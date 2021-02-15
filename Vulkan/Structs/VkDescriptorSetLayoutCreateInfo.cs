

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorSetLayoutCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDescriptorSetLayoutCreateFlags Flags { get; init; }

        public uint BindingCount { get; init; }

        public unsafe VkDescriptorSetLayoutBinding* Bindings { get; init; }
    }
}
