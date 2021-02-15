using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceGroupPresentCapabilities
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public UnmanagedArray32<uint> PresentMask { get; init; }

        public VkDeviceGroupPresentModeFlags Flags { get; init; }
    }
}
