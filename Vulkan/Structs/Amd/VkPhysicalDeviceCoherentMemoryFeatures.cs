

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Amd
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceCoherentMemoryFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 DeviceCoherentMemory { get; init; }
    }
}
