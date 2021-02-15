

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Khronos;
using Vulkan.Handles.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSwapchainCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkSwapchainCreateFlags Flags { get; init; }

        public VkSurface Surface { get; init; }

        public uint MinImageCount { get; init; }

        public VkFormat ImageFormat { get; init; }

        public VkColorSpace ImageColorSpace { get; init; }

        public VkExtent2D ImageExtent { get; init; }

        public uint ImageArrayLayers { get; init; }

        public VkImageUsageFlags ImageUsage { get; init; }

        public VkSharingMode ImageSharingMode { get; init; }

        public uint QueueFamilyIndexCount { get; init; }

        public unsafe uint* QueueFamilyIndices { get; init; }

        public VkSurfaceTransformFlags PreTransform { get; init; }

        public VkCompositeAlphaFlags CompositeAlpha { get; init; }

        public VkPresentMode PresentMode { get; init; }

        public VkBool32 Clipped { get; init; }

        public VkSwapchain OldSwapchain { get; init; }
    }
}
