

using System.Runtime.InteropServices;
using Vulkan.Enums.Khronos;
using Vulkan.Handles.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayProperties
    {
        public VkDisplay Display { get; init; }

        public unsafe byte* DisplayName { get; init; }

        public VkExtent2D PhysicalDimensions { get; init; }

        public VkExtent2D PhysicalResolution { get; init; }

        public VkSurfaceTransformFlags SupportedTransforms { get; init; }

        public VkBool32 PlaneReorderPossible { get; init; }

        public VkBool32 PersistentContent { get; init; }
    }
}
