

using System.Runtime.InteropServices;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCreationFeedback
    {
        public VkPipelineCreationFeedbackFlags Flags { get; init; }

        public ulong Duration { get; init; }
    }
}
