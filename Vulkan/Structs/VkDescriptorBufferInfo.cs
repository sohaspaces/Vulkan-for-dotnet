

using System.Runtime.InteropServices;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorBufferInfo
    {
        public VkBuffer Buffer { get; init; }

        public VkDeviceSize Offset { get; init; }

        public VkDeviceSize Range { get; init; }
    }
}
