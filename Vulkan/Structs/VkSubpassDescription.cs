

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassDescription
    {
        public VkSubpassDescriptionFlags Flags { get; init; }

        public VkPipelineBindPoint PipelineBindPoint { get; init; }

        public uint InputAttachmentCount { get; init; }

        public unsafe VkAttachmentReference* InputAttachments { get; init; }

        public uint ColorAttachmentCount { get; init; }

        public unsafe VkAttachmentReference* ColorAttachments { get; init; }

        public unsafe VkAttachmentReference* ResolveAttachments { get; init; }

        public unsafe VkAttachmentReference* DepthStencilAttachment { get; init; }

        public uint PreserveAttachmentCount { get; init; }

        public unsafe uint* PreserveAttachments { get; init; }
    }
}
