

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFragmentShaderInterlockFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 FragmentShaderSampleInterlock { get; init; }

        public VkBool32 FragmentShaderPixelInterlock { get; init; }

        public VkBool32 FragmentShaderShadingRateInterlock { get; init; }
    }
}
