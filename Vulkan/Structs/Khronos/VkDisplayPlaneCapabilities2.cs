

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPlaneCapabilities2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDisplayPlaneCapabilities Capabilities { get; init; }
    }
}
