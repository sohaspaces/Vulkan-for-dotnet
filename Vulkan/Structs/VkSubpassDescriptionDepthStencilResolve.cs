

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassDescriptionDepthStencilResolve
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkResolveModeFlags DepthResolveMode { get; init; }

        public VkResolveModeFlags StencilResolveMode { get; init; }

        public unsafe VkAttachmentReference2* DepthStencilResolveAttachment { get; init; }
    }
}
