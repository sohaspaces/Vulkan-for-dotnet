

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Amd
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderCoreProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint ShaderEngineCount { get; init; }

        public uint ShaderArraysPerEngineCount { get; init; }

        public uint ComputeUnitsPerShaderArray { get; init; }

        public uint SimdPerComputeUnit { get; init; }

        public uint WavefrontsPerSimd { get; init; }

        public uint WavefrontSize { get; init; }

        public uint SgprsPerSimd { get; init; }

        public uint MinSgprAllocation { get; init; }

        public uint MaxSgprAllocation { get; init; }

        public uint SgprAllocationGranularity { get; init; }

        public uint VgprsPerSimd { get; init; }

        public uint MinVgprAllocation { get; init; }

        public uint MaxVgprAllocation { get; init; }

        public uint VgprAllocationGranularity { get; init; }
    }
}
