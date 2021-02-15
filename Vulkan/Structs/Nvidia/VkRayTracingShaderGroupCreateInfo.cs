

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRayTracingShaderGroupCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkRayTracingShaderGroupType Type { get; init; }

        public uint GeneralShader { get; init; }

        public uint ClosestHitShader { get; init; }

        public uint AnyHitShader { get; init; }

        public uint IntersectionShader { get; init; }
    }
}
