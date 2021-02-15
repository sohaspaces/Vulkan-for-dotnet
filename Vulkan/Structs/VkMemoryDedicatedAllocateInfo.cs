

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryDedicatedAllocateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkImage Image { get; init; }

        public VkBuffer Buffer { get; init; }
    }
}
