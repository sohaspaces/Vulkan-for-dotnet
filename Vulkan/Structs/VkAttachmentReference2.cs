

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentReference2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint Attachment { get; init; }

        public VkImageLayout Layout { get; init; }

        public VkImageAspectFlags AspectMask { get; init; }
    }
}
