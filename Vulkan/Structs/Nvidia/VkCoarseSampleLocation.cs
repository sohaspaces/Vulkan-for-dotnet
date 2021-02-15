

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCoarseSampleLocation
    {
        public uint PixelX { get; init; }

        public uint PixelY { get; init; }

        public uint Sample { get; init; }
    }
}
