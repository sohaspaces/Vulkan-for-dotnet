using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
using Vulkan.Handles.Khronos;
using Vulkan.Structs;
using Vulkan.Structs.Google;
namespace Vulkan
{
    public static unsafe partial class VkGoogle
    {
        [DllImport("vulkan-1")] private static extern VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSurface surface);
        public static void CreateImagePipeSurface(VkInstance instance, ref VkImagePipeSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSurface surface) => vkCreateImagePipeSurfaceFUCHSIA(instance, ref createInfo, ref allocator, out surface).AssertSuccess(nameof(vkCreateImagePipeSurfaceFUCHSIA));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, [In, Out]VkImagePipeSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, out VkSurface surface);
        public static void CreateImagePipeSurface(VkInstance instance, [In, Out]VkImagePipeSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, out VkSurface surface) => vkCreateImagePipeSurfaceFUCHSIA(instance, createInfo, ref allocator, out surface).AssertSuccess(nameof(vkCreateImagePipeSurfaceFUCHSIA));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfo createInfo, [In, Out]VkAllocationCallbacks[] allocator, out VkSurface surface);
        public static void CreateImagePipeSurface(VkInstance instance, ref VkImagePipeSurfaceCreateInfo createInfo, [In, Out]VkAllocationCallbacks[] allocator, out VkSurface surface) => vkCreateImagePipeSurfaceFUCHSIA(instance, ref createInfo, allocator, out surface).AssertSuccess(nameof(vkCreateImagePipeSurfaceFUCHSIA));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, [In, Out]VkImagePipeSurfaceCreateInfo[] createInfo, [In, Out]VkAllocationCallbacks[] allocator, out VkSurface surface);
        public static void CreateImagePipeSurface(VkInstance instance, [In, Out]VkImagePipeSurfaceCreateInfo[] createInfo, [In, Out]VkAllocationCallbacks[] allocator, out VkSurface surface) => vkCreateImagePipeSurfaceFUCHSIA(instance, createInfo, allocator, out surface).AssertSuccess(nameof(vkCreateImagePipeSurfaceFUCHSIA));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, [In, Out]VkSurface[] surface);
        public static void CreateImagePipeSurface(VkInstance instance, ref VkImagePipeSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, [In, Out]VkSurface[] surface) => vkCreateImagePipeSurfaceFUCHSIA(instance, ref createInfo, ref allocator, surface).AssertSuccess(nameof(vkCreateImagePipeSurfaceFUCHSIA));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, [In, Out]VkImagePipeSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, [In, Out]VkSurface[] surface);
        public static void CreateImagePipeSurface(VkInstance instance, [In, Out]VkImagePipeSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, [In, Out]VkSurface[] surface) => vkCreateImagePipeSurfaceFUCHSIA(instance, createInfo, ref allocator, surface).AssertSuccess(nameof(vkCreateImagePipeSurfaceFUCHSIA));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, ref VkImagePipeSurfaceCreateInfo createInfo, [In, Out]VkAllocationCallbacks[] allocator, [In, Out]VkSurface[] surface);
        public static void CreateImagePipeSurface(VkInstance instance, ref VkImagePipeSurfaceCreateInfo createInfo, [In, Out]VkAllocationCallbacks[] allocator, [In, Out]VkSurface[] surface) => vkCreateImagePipeSurfaceFUCHSIA(instance, ref createInfo, allocator, surface).AssertSuccess(nameof(vkCreateImagePipeSurfaceFUCHSIA));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, [In, Out]VkImagePipeSurfaceCreateInfo[] createInfo, [In, Out]VkAllocationCallbacks[] allocator, [In, Out]VkSurface[] surface);
        public static void CreateImagePipeSurface(VkInstance instance, [In, Out]VkImagePipeSurfaceCreateInfo[] createInfo, [In, Out]VkAllocationCallbacks[] allocator, [In, Out]VkSurface[] surface) => vkCreateImagePipeSurfaceFUCHSIA(instance, createInfo, allocator, surface).AssertSuccess(nameof(vkCreateImagePipeSurfaceFUCHSIA));
        [DllImport("vulkan-1")] private static extern VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, nint buffer, out VkAndroidHardwareBufferProperties properties);
        public static void GetAndroidHardwareBufferProperties(VkDevice device, nint buffer, out VkAndroidHardwareBufferProperties properties) => vkGetAndroidHardwareBufferPropertiesANDROID(device, buffer, out properties).AssertSuccess(nameof(vkGetAndroidHardwareBufferPropertiesANDROID));
        [DllImport("vulkan-1")] private static extern VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, nint buffer, [In, Out]VkAndroidHardwareBufferProperties[] properties);
        public static void GetAndroidHardwareBufferProperties(VkDevice device, nint buffer, [In, Out]VkAndroidHardwareBufferProperties[] properties) => vkGetAndroidHardwareBufferPropertiesANDROID(device, buffer, properties).AssertSuccess(nameof(vkGetAndroidHardwareBufferPropertiesANDROID));
        [DllImport("vulkan-1")] private static extern VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, out VkMemoryGetAndroidHardwareBufferInfo info, nint buffer);
        public static void GetMemoryAndroidHardwareBuffer(VkDevice device, out VkMemoryGetAndroidHardwareBufferInfo info, nint buffer) => vkGetMemoryAndroidHardwareBufferANDROID(device, out info, buffer).AssertSuccess(nameof(vkGetMemoryAndroidHardwareBufferANDROID));
        [DllImport("vulkan-1")] private static extern VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, [In, Out]VkMemoryGetAndroidHardwareBufferInfo[] info, nint buffer);
        public static void GetMemoryAndroidHardwareBuffer(VkDevice device, [In, Out]VkMemoryGetAndroidHardwareBufferInfo[] info, nint buffer) => vkGetMemoryAndroidHardwareBufferANDROID(device, info, buffer).AssertSuccess(nameof(vkGetMemoryAndroidHardwareBufferANDROID));
        [DllImport("vulkan-1")] private static extern VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchain swapchain, ref uint presentationTimingCount, out VkPastPresentationTiming presentationTimings);
        public static void GetPastPresentationTiming(VkDevice device, VkSwapchain swapchain, ref uint presentationTimingCount, out VkPastPresentationTiming presentationTimings) => vkGetPastPresentationTimingGOOGLE(device, swapchain, ref presentationTimingCount, out presentationTimings).AssertSuccess(nameof(vkGetPastPresentationTimingGOOGLE));
        [DllImport("vulkan-1")] private static extern VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchain swapchain, [In, Out]uint[] presentationTimingCount, out VkPastPresentationTiming presentationTimings);
        public static void GetPastPresentationTiming(VkDevice device, VkSwapchain swapchain, [In, Out]uint[] presentationTimingCount, out VkPastPresentationTiming presentationTimings) => vkGetPastPresentationTimingGOOGLE(device, swapchain, presentationTimingCount, out presentationTimings).AssertSuccess(nameof(vkGetPastPresentationTimingGOOGLE));
        [DllImport("vulkan-1")] private static extern VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchain swapchain, ref uint presentationTimingCount, [In, Out]VkPastPresentationTiming[] presentationTimings);
        public static void GetPastPresentationTiming(VkDevice device, VkSwapchain swapchain, ref uint presentationTimingCount, [In, Out]VkPastPresentationTiming[] presentationTimings) => vkGetPastPresentationTimingGOOGLE(device, swapchain, ref presentationTimingCount, presentationTimings).AssertSuccess(nameof(vkGetPastPresentationTimingGOOGLE));
        [DllImport("vulkan-1")] private static extern VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchain swapchain, [In, Out]uint[] presentationTimingCount, [In, Out]VkPastPresentationTiming[] presentationTimings);
        public static void GetPastPresentationTiming(VkDevice device, VkSwapchain swapchain, [In, Out]uint[] presentationTimingCount, [In, Out]VkPastPresentationTiming[] presentationTimings) => vkGetPastPresentationTimingGOOGLE(device, swapchain, presentationTimingCount, presentationTimings).AssertSuccess(nameof(vkGetPastPresentationTimingGOOGLE));
        [DllImport("vulkan-1")] private static extern VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchain swapchain, out VkRefreshCycleDuration displayTimingProperties);
        public static void GetRefreshCycleDuration(VkDevice device, VkSwapchain swapchain, out VkRefreshCycleDuration displayTimingProperties) => vkGetRefreshCycleDurationGOOGLE(device, swapchain, out displayTimingProperties).AssertSuccess(nameof(vkGetRefreshCycleDurationGOOGLE));
        [DllImport("vulkan-1")] private static extern VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchain swapchain, [In, Out]VkRefreshCycleDuration[] displayTimingProperties);
        public static void GetRefreshCycleDuration(VkDevice device, VkSwapchain swapchain, [In, Out]VkRefreshCycleDuration[] displayTimingProperties) => vkGetRefreshCycleDurationGOOGLE(device, swapchain, displayTimingProperties).AssertSuccess(nameof(vkGetRefreshCycleDurationGOOGLE));
    }
}