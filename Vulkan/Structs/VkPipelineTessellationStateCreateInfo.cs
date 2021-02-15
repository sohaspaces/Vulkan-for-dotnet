

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineTessellationStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineTessellationStateCreateFlags Flags { get; init; }

        public uint PatchControlPoints { get; init; }
    }
}
