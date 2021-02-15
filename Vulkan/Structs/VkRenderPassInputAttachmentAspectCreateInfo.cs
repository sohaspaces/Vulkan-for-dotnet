

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRenderPassInputAttachmentAspectCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint AspectReferenceCount { get; init; }

        public unsafe VkInputAttachmentAspectReference* AspectReferences { get; init; }
    }
}
