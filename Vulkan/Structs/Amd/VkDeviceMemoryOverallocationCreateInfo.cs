

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Amd;
namespace Vulkan.Structs.Amd
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceMemoryOverallocationCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkMemoryOverallocationBehavior OverallocationBehavior { get; init; }
    }
}
