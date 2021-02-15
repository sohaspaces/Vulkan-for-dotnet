

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkXYColor
    {
        public float X { get; init; }

        public float Y { get; init; }
    }
}
