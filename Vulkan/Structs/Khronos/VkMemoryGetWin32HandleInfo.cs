

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryGetWin32HandleInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDeviceMemory Memory { get; init; }

        public VkExternalMemoryHandleTypeFlags HandleType { get; init; }
    }
}
