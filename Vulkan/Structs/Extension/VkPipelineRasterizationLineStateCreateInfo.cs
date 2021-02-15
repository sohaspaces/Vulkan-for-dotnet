

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineRasterizationLineStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkLineRasterizationMode LineRasterizationMode { get; init; }

        public VkBool32 StippledLineEnable { get; init; }

        public uint LineStippleFactor { get; init; }

        public ushort LineStipplePattern { get; init; }
    }
}
