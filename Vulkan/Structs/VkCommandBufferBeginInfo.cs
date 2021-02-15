

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCommandBufferBeginInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkCommandBufferUsageFlags Flags { get; init; }

        public unsafe VkCommandBufferInheritanceInfo* InheritanceInfo { get; init; }
    }
}
