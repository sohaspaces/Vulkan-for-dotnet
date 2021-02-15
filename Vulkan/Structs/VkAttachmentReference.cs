

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentReference
    {
        public uint Attachment { get; init; }

        public VkImageLayout Layout { get; init; }
    }
}
