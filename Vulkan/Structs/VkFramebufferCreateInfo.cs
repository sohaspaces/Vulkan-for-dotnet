

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFramebufferCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkFramebufferCreateFlags Flags { get; init; }

        public VkRenderPass RenderPass { get; init; }

        public uint AttachmentCount { get; init; }

        public unsafe VkImageView* Attachments { get; init; }

        public uint Width { get; init; }

        public uint Height { get; init; }

        public uint Layers { get; init; }
    }
}
