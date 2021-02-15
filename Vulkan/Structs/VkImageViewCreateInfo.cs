

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageViewCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkImageViewCreateFlags Flags { get; init; }

        public VkImage Image { get; init; }

        public VkImageViewType ViewType { get; init; }

        public VkFormat Format { get; init; }

        public VkComponentMapping Components { get; init; }

        public VkImageSubresourceRange SubresourceRange { get; init; }
    }
}
