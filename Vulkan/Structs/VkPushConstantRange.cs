

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPushConstantRange
    {
        public VkShaderStageFlags StageFlags { get; init; }

        public uint Offset { get; init; }

        public uint Size { get; init; }
    }
}
