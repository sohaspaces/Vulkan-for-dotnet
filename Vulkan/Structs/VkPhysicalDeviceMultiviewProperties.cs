

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMultiviewProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint MaxMultiviewViewCount { get; init; }

        public uint MaxMultiviewInstanceIndex { get; init; }
    }
}
