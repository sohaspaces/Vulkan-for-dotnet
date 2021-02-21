using System.Runtime.InteropServices;
using Vulkan.Handles;
using Vulkan.Structs.Nvidia.Experimental;
namespace Vulkan
{
    public static unsafe partial class VkNvx
    {
        [DllImport("vulkan-1")] private static extern uint vkGetImageViewHandleNVX(VkDevice device, out VkImageViewHandleInfo info);
        public static void GetImageViewHandle(VkDevice device, out VkImageViewHandleInfo info) => vkGetImageViewHandleNVX(device, out info);
        [DllImport("vulkan-1")] private static extern uint vkGetImageViewHandleNVX(VkDevice device, [In, Out]VkImageViewHandleInfo[] info);
        public static void GetImageViewHandle(VkDevice device, [In, Out]VkImageViewHandleInfo[] info) => vkGetImageViewHandleNVX(device, info);
    }
}