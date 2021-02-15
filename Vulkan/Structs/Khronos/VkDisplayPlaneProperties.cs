

using System.Runtime.InteropServices;
using Vulkan.Handles.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPlaneProperties
    {
        public VkDisplay CurrentDisplay { get; init; }

        public uint CurrentStackIndex { get; init; }
    }
}
