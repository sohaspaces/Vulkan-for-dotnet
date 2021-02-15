

using System.Runtime.InteropServices;
using Vulkan.Handles.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayModeProperties
    {
        public VkDisplayMode DisplayMode { get; init; }

        public VkDisplayModeParameters Parameters { get; init; }
    }
}
