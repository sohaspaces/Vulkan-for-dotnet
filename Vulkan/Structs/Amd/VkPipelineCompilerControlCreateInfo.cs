

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Intel;
namespace Vulkan.Structs.Amd
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCompilerControlCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineCompilerControlFlags CompilerControlFlags { get; init; }
    }
}
