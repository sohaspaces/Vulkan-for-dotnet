using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceToolProperties
    {
        public VkStructureType StructureType { get; init; }
        public unsafe void* Next { get; init; }
        public UnmanagedString256 Name { get; init; }
        public UnmanagedString256 Version { get; init; }
        public VkToolPurposeFlags Purpose { get; init; }
        public UnmanagedString256 Description { get; init; }
        public UnmanagedString256 Layer { get; init; }
    }
}
