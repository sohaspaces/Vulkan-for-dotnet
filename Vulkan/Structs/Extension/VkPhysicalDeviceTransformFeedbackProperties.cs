

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceTransformFeedbackProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint MaxTransformFeedbackStreams { get; init; }

        public uint MaxTransformFeedbackBuffers { get; init; }

        public VkDeviceSize MaxTransformFeedbackBufferSize { get; init; }

        public uint MaxTransformFeedbackStreamDataSize { get; init; }

        public uint MaxTransformFeedbackBufferDataSize { get; init; }

        public uint MaxTransformFeedbackBufferDataStride { get; init; }

        public VkBool32 TransformFeedbackQueries { get; init; }

        public VkBool32 TransformFeedbackStreamsLinesTriangles { get; init; }

        public VkBool32 TransformFeedbackRasterizationStreamSelect { get; init; }

        public VkBool32 TransformFeedbackDraw { get; init; }
    }
}
