

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Intel;
namespace Vulkan.Structs.Intel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceOverrideInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPerformanceOverrideType Type { get; init; }

        public VkBool32 Enable { get; init; }

        public ulong Parameter { get; init; }
    }
}
