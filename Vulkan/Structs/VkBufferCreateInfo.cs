

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBufferCreateFlags Flags { get; init; }

        public VkDeviceSize Size { get; init; }

        public VkBufferUsageFlags Usage { get; init; }

        public VkSharingMode SharingMode { get; init; }

        public uint QueueFamilyIndexCount { get; init; }

        public unsafe uint* QueueFamilyIndices { get; init; }
    }
}
