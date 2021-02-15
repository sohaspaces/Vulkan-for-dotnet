

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Google
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAndroidHardwareBufferProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDeviceSize AllocationSize { get; init; }

        public uint MemoryTypeBits { get; init; }
    }
}
