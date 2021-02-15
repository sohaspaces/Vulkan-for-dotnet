

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceBlendOperationAdvancedProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint AdvancedBlendMaxColorAttachments { get; init; }

        public VkBool32 AdvancedBlendIndependentBlend { get; init; }

        public VkBool32 AdvancedBlendNonPremultipliedSrcColor { get; init; }

        public VkBool32 AdvancedBlendNonPremultipliedDstColor { get; init; }

        public VkBool32 AdvancedBlendCorrelatedOverlap { get; init; }

        public VkBool32 AdvancedBlendAllOperations { get; init; }
    }
}
