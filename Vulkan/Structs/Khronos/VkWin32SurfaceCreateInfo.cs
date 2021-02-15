using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkWin32SurfaceCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkWin32SurfaceCreateFlags Flags { get; init; }



        public nint Hinstance { get; init; }



        public nint Hwnd { get; init; }
    }
}
