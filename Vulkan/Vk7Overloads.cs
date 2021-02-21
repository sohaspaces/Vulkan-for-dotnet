using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
using Vulkan.Handles.Khronos;
using Vulkan.Structs;
using Vulkan.Structs.Nintendo;
namespace Vulkan
{
    public static unsafe partial class VkNn
    {
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSurface surface);
        public static void CreateViSurface(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, out VkSurface surface) => vkCreateViSurfaceNN(instance, ref createInfo, ref allocator, out surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, [In, Out]VkViSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, out VkSurface surface);
        public static void CreateViSurface(VkInstance instance, [In, Out]VkViSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, out VkSurface surface) => vkCreateViSurfaceNN(instance, createInfo, ref allocator, out surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, [In, Out]VkAllocationCallbacks[] allocator, out VkSurface surface);
        public static void CreateViSurface(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, [In, Out]VkAllocationCallbacks[] allocator, out VkSurface surface) => vkCreateViSurfaceNN(instance, ref createInfo, allocator, out surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, [In, Out]VkViSurfaceCreateInfo[] createInfo, [In, Out]VkAllocationCallbacks[] allocator, out VkSurface surface);
        public static void CreateViSurface(VkInstance instance, [In, Out]VkViSurfaceCreateInfo[] createInfo, [In, Out]VkAllocationCallbacks[] allocator, out VkSurface surface) => vkCreateViSurfaceNN(instance, createInfo, allocator, out surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, [In, Out]VkSurface[] surface);
        public static void CreateViSurface(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, [In, Out]VkSurface[] surface) => vkCreateViSurfaceNN(instance, ref createInfo, ref allocator, surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, [In, Out]VkViSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, [In, Out]VkSurface[] surface);
        public static void CreateViSurface(VkInstance instance, [In, Out]VkViSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, [In, Out]VkSurface[] surface) => vkCreateViSurfaceNN(instance, createInfo, ref allocator, surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, [In, Out]VkAllocationCallbacks[] allocator, [In, Out]VkSurface[] surface);
        public static void CreateViSurface(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, [In, Out]VkAllocationCallbacks[] allocator, [In, Out]VkSurface[] surface) => vkCreateViSurfaceNN(instance, ref createInfo, allocator, surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, [In, Out]VkViSurfaceCreateInfo[] createInfo, [In, Out]VkAllocationCallbacks[] allocator, [In, Out]VkSurface[] surface);
        public static void CreateViSurface(VkInstance instance, [In, Out]VkViSurfaceCreateInfo[] createInfo, [In, Out]VkAllocationCallbacks[] allocator, [In, Out]VkSurface[] surface) => vkCreateViSurfaceNN(instance, createInfo, allocator, surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
    }
}