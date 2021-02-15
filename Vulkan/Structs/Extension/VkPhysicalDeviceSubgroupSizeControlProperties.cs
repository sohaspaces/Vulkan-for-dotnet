

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSubgroupSizeControlProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint MinSubgroupSize { get; init; }

        public uint MaxSubgroupSize { get; init; }

        public uint MaxComputeWorkgroupSubgroups { get; init; }

        public VkShaderStageFlags RequiredSubgroupSizeStages { get; init; }
    }
}
