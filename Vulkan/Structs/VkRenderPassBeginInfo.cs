

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRenderPassBeginInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkRenderPass RenderPass { get; init; }

        public VkFramebuffer Framebuffer { get; init; }

        public VkRect2D RenderArea { get; init; }

        public uint ClearValueCount { get; init; }

        public unsafe VkClearValue* ClearValues { get; init; }
    }
}
