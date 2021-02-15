

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSamplerFilterMinmaxProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 FilterMinmaxSingleComponentFormats { get; init; }

        public VkBool32 FilterMinmaxImageComponentMapping { get; init; }
    }
}
