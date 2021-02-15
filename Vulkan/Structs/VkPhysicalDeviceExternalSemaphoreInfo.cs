

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceExternalSemaphoreInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkExternalSemaphoreHandleTypeFlags HandleType { get; init; }
    }
}
