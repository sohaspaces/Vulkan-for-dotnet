

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentDensityMapProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkExtent2D MinFragmentDensityTexelSize { get; init; }

        public VkExtent2D MaxFragmentDensityTexelSize { get; init; }

        public VkBool32 FragmentDensityInvocations { get; init; }
    }
}
