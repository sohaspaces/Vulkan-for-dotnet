

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageDrmFormatModifierListCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint DrmFormatModifierCount { get; init; }

        public unsafe ulong* DrmFormatModifiers { get; init; }
    }
}
