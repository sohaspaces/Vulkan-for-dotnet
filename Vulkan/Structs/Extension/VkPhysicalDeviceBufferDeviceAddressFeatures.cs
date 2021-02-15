

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceBufferDeviceAddressFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 BufferDeviceAddress { get; init; }

        public VkBool32 BufferDeviceAddressCaptureReplay { get; init; }

        public VkBool32 BufferDeviceAddressMultiDevice { get; init; }
    }
}
