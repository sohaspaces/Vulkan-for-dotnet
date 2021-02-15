

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineRasterizationDepthClipStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineRasterizationDepthClipStateCreateFlags Flags { get; init; }

        public VkBool32 DepthClipEnable { get; init; }
    }
}
