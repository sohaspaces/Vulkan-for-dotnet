

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceImageDrmFormatModifierInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public ulong DrmFormatModifier { get; init; }

        public VkSharingMode SharingMode { get; init; }

        public uint QueueFamilyIndexCount { get; init; }

        public unsafe uint* QueueFamilyIndices { get; init; }
    }
}
