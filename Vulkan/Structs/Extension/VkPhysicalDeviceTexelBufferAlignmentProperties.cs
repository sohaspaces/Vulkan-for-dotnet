

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceTexelBufferAlignmentProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDeviceSize StorageTexelBufferOffsetAlignmentBytes { get; init; }

        public VkBool32 StorageTexelBufferOffsetSingleTexelAlignment { get; init; }

        public VkDeviceSize UniformTexelBufferOffsetAlignmentBytes { get; init; }

        public VkBool32 UniformTexelBufferOffsetSingleTexelAlignment { get; init; }
    }
}
