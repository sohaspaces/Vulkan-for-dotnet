

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassDescription2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkSubpassDescriptionFlags Flags { get; init; }

        public VkPipelineBindPoint PipelineBindPoint { get; init; }

        public uint ViewMask { get; init; }

        public uint InputAttachmentCount { get; init; }

        public unsafe VkAttachmentReference2* InputAttachments { get; init; }

        public uint ColorAttachmentCount { get; init; }

        public unsafe VkAttachmentReference2* ColorAttachments { get; init; }

        public unsafe VkAttachmentReference2* ResolveAttachments { get; init; }

        public unsafe VkAttachmentReference2* DepthStencilAttachment { get; init; }

        public uint PreserveAttachmentCount { get; init; }

        public unsafe uint* PreserveAttachments { get; init; }
    }
}
