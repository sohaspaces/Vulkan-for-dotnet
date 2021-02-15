

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugMarkerMarkerInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public unsafe byte* MarkerName { get; init; }

        public UnmanagedArray4<float> Color { get; init; }
    }
}
