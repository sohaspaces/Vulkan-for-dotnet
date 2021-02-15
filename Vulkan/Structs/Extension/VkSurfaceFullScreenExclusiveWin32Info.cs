using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSurfaceFullScreenExclusiveWin32Info
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }



        public nint Hmonitor { get; init; }
    }
}
