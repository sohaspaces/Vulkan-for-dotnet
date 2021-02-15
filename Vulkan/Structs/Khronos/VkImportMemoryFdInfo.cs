

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImportMemoryFdInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkExternalMemoryHandleTypeFlags HandleType { get; init; }

        public int Fd { get; init; }
    }
}
