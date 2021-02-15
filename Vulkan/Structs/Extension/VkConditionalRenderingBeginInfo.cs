

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
using Vulkan.Handles;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkConditionalRenderingBeginInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBuffer Buffer { get; init; }

        public VkDeviceSize Offset { get; init; }

        public VkConditionalRenderingFlags Flags { get; init; }
    }
}
