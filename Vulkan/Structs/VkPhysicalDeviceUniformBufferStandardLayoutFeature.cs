

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 UniformBufferStandardLayout { get; init; }
    }
}
