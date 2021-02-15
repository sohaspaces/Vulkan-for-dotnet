using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMemoryProperties
    {
        public uint MemoryTypeCount { get; init; }
        public UnmanagedArray32<VkMemoryType> MemoryTypes { get; init; }
        public uint MemoryHeapCount { get; init; }
        public UnmanagedArray32<VkMemoryHeap> MemoryHeaps { get; init; }
    }
}
