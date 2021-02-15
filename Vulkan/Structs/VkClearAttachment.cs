using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkClearAttachment
    {
        public VkImageAspectFlags AspectMask { get; init; }
        public uint ColorAttachment { get; init; }
        public VkClearValue ClearValue { get; init; }
    }
}
