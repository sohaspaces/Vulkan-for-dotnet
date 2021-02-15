

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Intel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceStreamMarkerInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint Marker { get; init; }
    }
}
