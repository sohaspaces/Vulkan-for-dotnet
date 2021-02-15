using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImportFenceWin32HandleInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkFence Fence { get; init; }

        public VkFenceImportFlags Flags { get; init; }

        public VkExternalFenceHandleTypeFlags HandleType { get; init; }



        public nint Handle { get; init; }

        public unsafe byte* Name { get; init; }
    }
}
