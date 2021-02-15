using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExportSemaphoreWin32HandleInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }



        public nint Attributes { get; init; }

        public uint DwAccess { get; init; }

        public unsafe byte* Name { get; init; }
    }
}
