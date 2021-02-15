

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassDependency2
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint SrcSubpass { get; init; }

        public uint DstSubpass { get; init; }

        public VkPipelineStageFlags SrcStageMask { get; init; }

        public VkPipelineStageFlags DstStageMask { get; init; }

        public VkAccessFlags SrcAccessMask { get; init; }

        public VkAccessFlags DstAccessMask { get; init; }

        public VkDependencyFlags DependencyFlags { get; init; }

        public int ViewOffset { get; init; }
    }
}
