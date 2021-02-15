

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentDescriptionStencilLayout
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkImageLayout StencilInitialLayout { get; init; }

        public VkImageLayout StencilFinalLayout { get; init; }
    }
}
