

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineColorBlendAdvancedStateCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 SrcPremultiplied { get; init; }

        public VkBool32 DstPremultiplied { get; init; }

        public VkBlendOverlap BlendOverlap { get; init; }
    }
}
