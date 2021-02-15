

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCoverageModulationStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineCoverageModulationStateCreateFlags Flags { get; init; }

        public VkCoverageModulationMode CoverageModulationMode { get; init; }

        public VkBool32 CoverageModulationTableEnable { get; init; }

        public uint CoverageModulationTableCount { get; init; }

        public unsafe float* CoverageModulationTable { get; init; }
    }
}
