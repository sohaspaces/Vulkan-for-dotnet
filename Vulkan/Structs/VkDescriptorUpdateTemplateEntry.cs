using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorUpdateTemplateEntry
    {
        public uint DstBinding { get; init; }

        public uint DstArrayElement { get; init; }

        public uint DescriptorCount { get; init; }

        public VkDescriptorType DescriptorType { get; init; }



        public nuint Offset { get; init; }



        public nuint Stride { get; init; }
    }
}
