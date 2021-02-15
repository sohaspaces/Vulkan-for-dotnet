

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceGroupPresentInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint SwapchainCount { get; init; }

        public unsafe uint* DeviceMasks { get; init; }

        public VkDeviceGroupPresentModeFlags Mode { get; init; }
    }
}
