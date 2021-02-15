

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkConformanceVersion
    {
        public byte Major { get; init; }

        public byte Minor { get; init; }

        public byte Subminor { get; init; }

        public byte Patch { get; init; }
    }
}
