using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExportMemoryWin32HandleInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }



        public nint Attributes { get; init; }

        public int DwAccess { get; init; }
    }
}
