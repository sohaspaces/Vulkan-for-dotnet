

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Intel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceMarkerInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public ulong Marker { get; init; }
    }
}
