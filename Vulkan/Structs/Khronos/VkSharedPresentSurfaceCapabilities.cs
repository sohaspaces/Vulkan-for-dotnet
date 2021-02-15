

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSharedPresentSurfaceCapabilities
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkImageUsageFlags SharedPresentSupportedUsageFlags { get; init; }
    }
}
