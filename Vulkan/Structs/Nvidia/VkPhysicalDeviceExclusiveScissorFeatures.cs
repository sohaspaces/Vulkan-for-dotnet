

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceExclusiveScissorFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 ExclusiveScissor { get; init; }
    }
}
