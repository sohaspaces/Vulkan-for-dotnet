

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineExecutableInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipeline Pipeline { get; init; }

        public uint ExecutableIndex { get; init; }
    }
}
