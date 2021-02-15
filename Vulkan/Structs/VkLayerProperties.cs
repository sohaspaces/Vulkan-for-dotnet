using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkLayerProperties
    {
        public UnmanagedString256 LayerName { get; init; }
        public uint SpecVersion { get; init; }
        public uint ImplementationVersion { get; init; }
        public UnmanagedString256 Description { get; init; }
    }
}
