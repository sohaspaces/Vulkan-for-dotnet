

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRenderPassMultiviewCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint SubpassCount { get; init; }

        public unsafe uint* ViewMasks { get; init; }

        public uint DependencyCount { get; init; }

        public unsafe int* ViewOffsets { get; init; }

        public uint CorrelationMaskCount { get; init; }

        public unsafe uint* CorrelationMasks { get; init; }
    }
}
