

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkValidationFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint EnabledValidationFeatureCount { get; init; }

        public unsafe VkValidationFeatureEnable* EnabledValidationFeatures { get; init; }

        public uint DisabledValidationFeatureCount { get; init; }

        public unsafe VkValidationFeatureDisable* DisabledValidationFeatures { get; init; }
    }
}
