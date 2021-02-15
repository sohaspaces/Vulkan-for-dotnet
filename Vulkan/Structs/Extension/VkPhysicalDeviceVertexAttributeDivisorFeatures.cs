

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVertexAttributeDivisorFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 VertexAttributeInstanceRateDivisor { get; init; }

        public VkBool32 VertexAttributeInstanceRateZeroDivisor { get; init; }
    }
}
