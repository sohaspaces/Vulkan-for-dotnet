

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentDescription
    {
        public VkAttachmentDescriptionFlags Flags { get; init; }

        public VkFormat Format { get; init; }

        public VkSampleCountFlags Samples { get; init; }

        public VkAttachmentLoadOp LoadOp { get; init; }

        public VkAttachmentStoreOp StoreOp { get; init; }

        public VkAttachmentLoadOp StencilLoadOp { get; init; }

        public VkAttachmentStoreOp StencilStoreOp { get; init; }

        public VkImageLayout InitialLayout { get; init; }

        public VkImageLayout FinalLayout { get; init; }
    }
}
