

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceComputeShaderDerivativesFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 ComputeDerivativeGroupQuads { get; init; }

        public VkBool32 ComputeDerivativeGroupLinear { get; init; }
    }
}
