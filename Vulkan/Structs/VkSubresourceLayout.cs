

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubresourceLayout
    {
        public VkDeviceSize Offset { get; init; }

        public VkDeviceSize Size { get; init; }

        public VkDeviceSize RowPitch { get; init; }

        public VkDeviceSize ArrayPitch { get; init; }

        public VkDeviceSize DepthPitch { get; init; }
    }
}
