using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
using Vulkan.Handles.Khronos;
using Vulkan.Structs;
using Vulkan.Structs.Google;
namespace Vulkan
{
    public static unsafe class VkGoogle
    {
        [DllImport("vulkan-1")] private static extern VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkSurface* surface);
        public static void CreateImagePipeSurface(VkInstance instance, VkImagePipeSurfaceCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkSurface* surface) => vkCreateImagePipeSurfaceFUCHSIA(instance, createInfo, allocator, surface).AssertSuccess(nameof(vkCreateImagePipeSurfaceFUCHSIA));
        [DllImport("vulkan-1")] private static extern VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, nint buffer, VkAndroidHardwareBufferProperties* properties);
        public static void GetAndroidHardwareBufferProperties(VkDevice device, nint buffer, VkAndroidHardwareBufferProperties* properties) => vkGetAndroidHardwareBufferPropertiesANDROID(device, buffer, properties).AssertSuccess(nameof(vkGetAndroidHardwareBufferPropertiesANDROID));
        [DllImport("vulkan-1")] private static extern VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfo* info, nint buffer);
        public static void GetMemoryAndroidHardwareBuffer(VkDevice device, VkMemoryGetAndroidHardwareBufferInfo* info, nint buffer) => vkGetMemoryAndroidHardwareBufferANDROID(device, info, buffer).AssertSuccess(nameof(vkGetMemoryAndroidHardwareBufferANDROID));
        [DllImport("vulkan-1")] private static extern VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchain swapchain, uint* presentationTimingCount, VkPastPresentationTiming* presentationTimings);
        public static void GetPastPresentationTiming(VkDevice device, VkSwapchain swapchain, uint* presentationTimingCount, VkPastPresentationTiming* presentationTimings) => vkGetPastPresentationTimingGOOGLE(device, swapchain, presentationTimingCount, presentationTimings).AssertSuccess(nameof(vkGetPastPresentationTimingGOOGLE));
        [DllImport("vulkan-1")] private static extern VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchain swapchain, VkRefreshCycleDuration* displayTimingProperties);
        public static void GetRefreshCycleDuration(VkDevice device, VkSwapchain swapchain, VkRefreshCycleDuration* displayTimingProperties) => vkGetRefreshCycleDurationGOOGLE(device, swapchain, displayTimingProperties).AssertSuccess(nameof(vkGetRefreshCycleDurationGOOGLE));
    }
}