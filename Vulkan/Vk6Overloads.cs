using System.Runtime.InteropServices;
using Vulkan.Handles;
using Vulkan.Structs.Nvidia.Experimental;
namespace Vulkan
{
    public static unsafe partial class VkNvx
    {
        [DllImport("vulkan-1")] private static extern uint vkGetImageViewHandleNVX(VkDevice device, ref VkImageViewHandleInfo info);
        public static void GetImageViewHandle(VkDevice device, ref VkImageViewHandleInfo info) => vkGetImageViewHandleNVX(device, ref info);
        [DllImport("vulkan-1")] private static extern uint vkGetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfo[] info);
        public static void GetImageViewHandle(VkDevice device, VkImageViewHandleInfo[] info) => vkGetImageViewHandleNVX(device, info);
    }
}