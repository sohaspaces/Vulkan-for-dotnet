

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRenderPassCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkRenderPassCreateFlags Flags { get; init; }

        public uint AttachmentCount { get; init; }

        public unsafe VkAttachmentDescription* Attachments { get; init; }

        public uint SubpassCount { get; init; }

        public unsafe VkSubpassDescription* Subpasses { get; init; }

        public uint DependencyCount { get; init; }

        public unsafe VkSubpassDependency* Dependencies { get; init; }
    }
}
