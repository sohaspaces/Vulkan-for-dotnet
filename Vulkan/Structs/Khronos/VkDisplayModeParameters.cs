

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayModeParameters
    {
        public VkExtent2D VisibleRegion { get; init; }

        public uint RefreshRate { get; init; }
    }
}
