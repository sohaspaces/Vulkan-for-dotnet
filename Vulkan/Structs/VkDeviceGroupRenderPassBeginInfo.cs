

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceGroupRenderPassBeginInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint DeviceMask { get; init; }

        public uint DeviceRenderAreaCount { get; init; }

        public unsafe VkRect2D* DeviceRenderAreas { get; init; }
    }
}
