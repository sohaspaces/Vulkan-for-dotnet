

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineColorBlendStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineColorBlendStateCreateFlags Flags { get; init; }

        public VkBool32 LogicOpEnable { get; init; }

        public VkLogicOp LogicOp { get; init; }

        public uint AttachmentCount { get; init; }

        public unsafe VkPipelineColorBlendAttachmentState* Attachments { get; init; }

        public UnmanagedArray4<float> BlendConstants { get; init; }
    }
}
