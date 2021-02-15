

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Amd;
namespace Vulkan.Structs.Amd
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderCoreProperties2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkShaderCorePropertiesFlags ShaderCoreFeatures { get; init; }

        public uint ActiveComputeUnitCount { get; init; }
    }
}
