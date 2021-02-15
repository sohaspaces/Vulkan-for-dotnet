

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
using Vulkan.Handles.Nvidia.Experimental;
namespace Vulkan.Structs.Nvidia.Experimental
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCmdProcessCommandsInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkObjectTable ObjectTable { get; init; }

        public VkIndirectCommandsLayout IndirectCommandsLayout { get; init; }

        public uint IndirectCommandsTokenCount { get; init; }

        public unsafe VkIndirectCommandsToken* IndirectCommandsTokens { get; init; }

        public uint MaxSequencesCount { get; init; }

        public VkCommandBuffer TargetCommandBuffer { get; init; }

        public VkBuffer SequencesCountBuffer { get; init; }

        public VkDeviceSize SequencesCountOffset { get; init; }

        public VkBuffer SequencesIndexBuffer { get; init; }

        public VkDeviceSize SequencesIndexOffset { get; init; }
    }
}
