

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nvidia.Experimental;
namespace Vulkan.Structs.Nvidia.Experimental
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkIndirectCommandsLayoutCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineBindPoint PipelineBindPoint { get; init; }

        public VkIndirectCommandsLayoutUsageFlags Flags { get; init; }

        public uint TokenCount { get; init; }

        public unsafe VkIndirectCommandsLayoutToken* Tokens { get; init; }
    }
}
