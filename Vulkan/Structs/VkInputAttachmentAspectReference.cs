

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkInputAttachmentAspectReference
    {
        public uint Subpass { get; init; }

        public uint InputAttachmentIndex { get; init; }

        public VkImageAspectFlags AspectMask { get; init; }
    }
}
