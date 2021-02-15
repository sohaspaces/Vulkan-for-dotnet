

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceQueueInfo2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDeviceQueueCreateFlags Flags { get; init; }

        public uint QueueFamilyIndex { get; init; }

        public uint QueueIndex { get; init; }
    }
}
