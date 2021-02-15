

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryDedicatedRequirements
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 PrefersDedicatedAllocation { get; init; }

        public VkBool32 RequiresDedicatedAllocation { get; init; }
    }
}
