

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkInstanceCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkInstanceCreateFlags Flags { get; init; }

        public unsafe VkApplicationInfo* ApplicationInfo { get; init; }

        public uint EnabledLayerCount { get; init; }

        public unsafe byte* PpEnabledLayerNames { get; init; }

        public uint EnabledExtensionCount { get; init; }

        public unsafe byte* PpEnabledExtensionNames { get; init; }
    }
}
