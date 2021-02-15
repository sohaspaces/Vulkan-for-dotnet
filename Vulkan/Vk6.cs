using System.Runtime.InteropServices;
using Vulkan.Handles;
using Vulkan.Structs.Nvidia.Experimental;
namespace Vulkan
{
    public static unsafe class VkNvx
    {
        [DllImport("vulkan-1")] private static extern uint vkGetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfo* info);
        public static uint GetImageViewHandle(VkDevice device, VkImageViewHandleInfo* info) => vkGetImageViewHandleNVX(device, info);
    }
}