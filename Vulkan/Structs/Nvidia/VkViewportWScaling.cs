

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkViewportWScaling
    {
        public float Xcoeff { get; init; }

        public float Ycoeff { get; init; }
    }
}
