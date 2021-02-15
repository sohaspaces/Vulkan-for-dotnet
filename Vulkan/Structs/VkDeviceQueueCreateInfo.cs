

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceQueueCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDeviceQueueCreateFlags Flags { get; init; }

        public uint QueueFamilyIndex { get; init; }

        public uint QueueCount { get; init; }

        public unsafe float* QueuePriorities { get; init; }
    }
}
