

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFramebufferAttachmentsCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint AttachmentImageInfoCount { get; init; }

        public unsafe VkFramebufferAttachmentImageInfo* AttachmentImageInfos { get; init; }
    }
}
