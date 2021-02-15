

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFloatControlsProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkShaderFloatControlsIndependence DenormBehaviorIndependence { get; init; }

        public VkShaderFloatControlsIndependence RoundingModeIndependence { get; init; }

        public VkBool32 ShaderSignedZeroInfNanPreserveFloat16 { get; init; }

        public VkBool32 ShaderSignedZeroInfNanPreserveFloat32 { get; init; }

        public VkBool32 ShaderSignedZeroInfNanPreserveFloat64 { get; init; }

        public VkBool32 ShaderDenormPreserveFloat16 { get; init; }

        public VkBool32 ShaderDenormPreserveFloat32 { get; init; }

        public VkBool32 ShaderDenormPreserveFloat64 { get; init; }

        public VkBool32 ShaderDenormFlushToZeroFloat16 { get; init; }

        public VkBool32 ShaderDenormFlushToZeroFloat32 { get; init; }

        public VkBool32 ShaderDenormFlushToZeroFloat64 { get; init; }

        public VkBool32 ShaderRoundingModeRTEFloat16 { get; init; }

        public VkBool32 ShaderRoundingModeRTEFloat32 { get; init; }

        public VkBool32 ShaderRoundingModeRTEFloat64 { get; init; }

        public VkBool32 ShaderRoundingModeRTZFloat16 { get; init; }

        public VkBool32 ShaderRoundingModeRTZFloat32 { get; init; }

        public VkBool32 ShaderRoundingModeRTZFloat64 { get; init; }
    }
}
