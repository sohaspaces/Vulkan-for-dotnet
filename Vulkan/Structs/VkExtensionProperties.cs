using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExtensionProperties
    {
        public UnmanagedString256 ExtensionName { get; init; }
        public uint SpecVersion { get; init; }
    }
}
