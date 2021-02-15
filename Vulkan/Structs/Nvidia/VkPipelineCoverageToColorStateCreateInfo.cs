

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCoverageToColorStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineCoverageToColorStateCreateFlags Flags { get; init; }

        public VkBool32 CoverageToColorEnable { get; init; }

        public uint CoverageToColorLocation { get; init; }
    }
}
