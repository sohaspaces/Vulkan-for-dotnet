

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevicePCIBusInfoProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint PciDomain { get; init; }

        public uint PciBus { get; init; }

        public uint PciDevice { get; init; }

        public uint PciFunction { get; init; }
    }
}
