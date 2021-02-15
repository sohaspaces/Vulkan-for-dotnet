

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSubgroupProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint SubgroupSize { get; init; }

        public VkShaderStageFlags SupportedStages { get; init; }

        public VkSubgroupFeatureFlags SupportedOperations { get; init; }

        public VkBool32 QuadOperationsInAllStages { get; init; }
    }
}
