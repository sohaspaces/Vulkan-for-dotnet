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
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, ref VkSurface surface);
        public static void CreateViSurface(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, ref VkSurface surface) => vkCreateViSurfaceNN(instance, ref createInfo, ref allocator, ref surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, ref VkSurface surface);
        public static void CreateViSurface(VkInstance instance, VkViSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, ref VkSurface surface) => vkCreateViSurfaceNN(instance, createInfo, ref allocator, ref surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, VkAllocationCallbacks[] allocator, ref VkSurface surface);
        public static void CreateViSurface(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, VkAllocationCallbacks[] allocator, ref VkSurface surface) => vkCreateViSurfaceNN(instance, ref createInfo, allocator, ref surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfo[] createInfo, VkAllocationCallbacks[] allocator, ref VkSurface surface);
        public static void CreateViSurface(VkInstance instance, VkViSurfaceCreateInfo[] createInfo, VkAllocationCallbacks[] allocator, ref VkSurface surface) => vkCreateViSurfaceNN(instance, createInfo, allocator, ref surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, VkSurface[] surface);
        public static void CreateViSurface(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, ref VkAllocationCallbacks allocator, VkSurface[] surface) => vkCreateViSurfaceNN(instance, ref createInfo, ref allocator, surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, VkSurface[] surface);
        public static void CreateViSurface(VkInstance instance, VkViSurfaceCreateInfo[] createInfo, ref VkAllocationCallbacks allocator, VkSurface[] surface) => vkCreateViSurfaceNN(instance, createInfo, ref allocator, surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, VkAllocationCallbacks[] allocator, VkSurface[] surface);
        public static void CreateViSurface(VkInstance instance, ref VkViSurfaceCreateInfo createInfo, VkAllocationCallbacks[] allocator, VkSurface[] surface) => vkCreateViSurfaceNN(instance, ref createInfo, allocator, surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfo[] createInfo, VkAllocationCallbacks[] allocator, VkSurface[] surface);
        public static void CreateViSurface(VkInstance instance, VkViSurfaceCreateInfo[] createInfo, VkAllocationCallbacks[] allocator, VkSurface[] surface) => vkCreateViSurfaceNN(instance, createInfo, allocator, surface).AssertSuccess(nameof(vkCreateViSurfaceNN));
    }
}