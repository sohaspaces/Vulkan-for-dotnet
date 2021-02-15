

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRenderPassCreateInfo2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkRenderPassCreateFlags Flags { get; init; }

        public uint AttachmentCount { get; init; }

        public unsafe VkAttachmentDescription2* Attachments { get; init; }

        public uint SubpassCount { get; init; }

        public unsafe VkSubpassDescription2* Subpasses { get; init; }

        public uint DependencyCount { get; init; }

        public unsafe VkSubpassDependency2* Dependencies { get; init; }

        public uint CorrelatedViewMaskCount { get; init; }

        public unsafe uint* CorrelatedViewMasks { get; init; }
    }
}
