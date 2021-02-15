

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentDensityMapFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 FragmentDensityMap { get; init; }

        public VkBool32 FragmentDensityMapDynamic { get; init; }

        public VkBool32 FragmentDensityMapNonSubsampledImages { get; init; }
    }
}
