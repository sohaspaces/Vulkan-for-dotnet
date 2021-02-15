

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseMemoryBind
    {
        public VkDeviceSize ResourceOffset { get; init; }

        public VkDeviceSize Size { get; init; }

        public VkDeviceMemory Memory { get; init; }

        public VkDeviceSize MemoryOffset { get; init; }

        public VkSparseMemoryBindFlags Flags { get; init; }
    }
}
