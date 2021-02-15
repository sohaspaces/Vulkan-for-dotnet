

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Intel;
namespace Vulkan.Structs.Intel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceConfigurationAcquireInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPerformanceConfigurationType Type { get; init; }
    }
}
