

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueueFamilyProperties
    {
        public VkQueueFlags QueueFlags { get; init; }

        public uint QueueCount { get; init; }

        public uint TimestampValidBits { get; init; }

        public VkExtent3D MinImageTransferGranularity { get; init; }
    }
}
