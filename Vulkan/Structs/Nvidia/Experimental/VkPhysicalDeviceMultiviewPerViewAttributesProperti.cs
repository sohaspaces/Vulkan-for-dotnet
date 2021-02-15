

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia.Experimental
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMultiviewPerViewAttributesProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 PerViewPositionAllComponents { get; init; }
    }
}
