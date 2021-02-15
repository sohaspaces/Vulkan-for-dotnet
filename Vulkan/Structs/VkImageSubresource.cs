

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageSubresource
    {
        public VkImageAspectFlags AspectMask { get; init; }

        public uint MipLevel { get; init; }

        public uint ArrayLayer { get; init; }
    }
}
