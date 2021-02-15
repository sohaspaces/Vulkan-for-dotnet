

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImportMemoryHostPointerInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkExternalMemoryHandleTypeFlags HandleType { get; init; }

        public unsafe void* HostPointer { get; init; }
    }
}
