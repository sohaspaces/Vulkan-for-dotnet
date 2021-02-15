

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMultiviewFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 Multiview { get; init; }

        public VkBool32 MultiviewGeometryShader { get; init; }

        public VkBool32 MultiviewTessellationShader { get; init; }
    }
}
