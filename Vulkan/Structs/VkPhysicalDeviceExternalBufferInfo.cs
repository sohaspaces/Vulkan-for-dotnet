

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceExternalBufferInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBufferCreateFlags Flags { get; init; }

        public VkBufferUsageFlags Usage { get; init; }

        public VkExternalMemoryHandleTypeFlags HandleType { get; init; }
    }
}
