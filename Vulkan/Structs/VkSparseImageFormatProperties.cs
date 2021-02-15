

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageFormatProperties
    {
        public VkImageAspectFlags AspectMask { get; init; }

        public VkExtent3D ImageGranularity { get; init; }

        public VkSparseImageFormatFlags Flags { get; init; }
    }
}
