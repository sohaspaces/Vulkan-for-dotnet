

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindImageMemoryInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkImage Image { get; init; }

        public VkDeviceMemory Memory { get; init; }

        public VkDeviceSize MemoryOffset { get; init; }
    }
}
