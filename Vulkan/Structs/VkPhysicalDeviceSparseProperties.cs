

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSparseProperties
    {
        public VkBool32 ResidencyStandard2DBlockShape { get; init; }

        public VkBool32 ResidencyStandard2DMultisampleBlockShape { get; init; }

        public VkBool32 ResidencyStandard3DBlockShape { get; init; }

        public VkBool32 ResidencyAlignedMipSize { get; init; }

        public VkBool32 ResidencyNonResidentStrict { get; init; }
    }
}
