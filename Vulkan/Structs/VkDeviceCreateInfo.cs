

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDeviceCreateFlags Flags { get; init; }

        public uint QueueCreateInfoCount { get; init; }

        public unsafe VkDeviceQueueCreateInfo* QueueCreateInfos { get; init; }

        public uint EnabledLayerCount { get; init; }

        public unsafe byte** PpEnabledLayerNames { get; init; }

        public uint EnabledExtensionCount { get; init; }

        public unsafe byte** PpEnabledExtensionNames { get; init; }

        public unsafe VkPhysicalDeviceFeatures* EnabledFeatures { get; init; }
    }
}
