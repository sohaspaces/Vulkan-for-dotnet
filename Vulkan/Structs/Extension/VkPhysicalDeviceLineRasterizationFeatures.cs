

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceLineRasterizationFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 RectangularLines { get; init; }

        public VkBool32 BresenhamLines { get; init; }

        public VkBool32 SmoothLines { get; init; }

        public VkBool32 StippledRectangularLines { get; init; }

        public VkBool32 StippledBresenhamLines { get; init; }

        public VkBool32 StippledSmoothLines { get; init; }
    }
}
