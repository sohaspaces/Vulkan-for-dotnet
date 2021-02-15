using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImportMemoryWin32HandleInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkExternalMemoryHandleTypeFlags HandleType { get; init; }



        public nint Handle { get; init; }

        public unsafe byte* Name { get; init; }
    }
}
