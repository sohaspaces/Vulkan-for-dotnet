

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkWriteDescriptorSetInlineUniformBlock
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint DataSize { get; init; }

        public unsafe void* Data { get; init; }
    }
}
