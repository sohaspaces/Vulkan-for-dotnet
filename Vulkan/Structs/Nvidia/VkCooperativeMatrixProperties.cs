

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCooperativeMatrixProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint MSize { get; init; }

        public uint NSize { get; init; }

        public uint KSize { get; init; }

        public VkComponentType AType { get; init; }

        public VkComponentType BType { get; init; }

        public VkComponentType CType { get; init; }

        public VkComponentType DType { get; init; }

        public VkScope Scope { get; init; }
    }
}
