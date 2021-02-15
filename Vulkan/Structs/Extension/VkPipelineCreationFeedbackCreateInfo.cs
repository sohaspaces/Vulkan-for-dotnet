

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCreationFeedbackCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public unsafe VkPipelineCreationFeedback* PipelineCreationFeedback { get; init; }

        public uint PipelineStageCreationFeedbackCount { get; init; }

        public unsafe VkPipelineCreationFeedback* PipelineStageCreationFeedbacks { get; init; }
    }
}
