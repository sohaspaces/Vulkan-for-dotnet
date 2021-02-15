

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSemaphoreGetFdInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkSemaphore Semaphore { get; init; }

        public VkExternalSemaphoreHandleTypeFlags HandleType { get; init; }
    }
}
