

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkStencilOpState
    {
        public VkStencilOp FailOp { get; init; }

        public VkStencilOp PassOp { get; init; }

        public VkStencilOp DepthFailOp { get; init; }

        public VkCompareOp CompareOp { get; init; }

        public uint CompareMask { get; init; }

        public uint WriteMask { get; init; }

        public uint Reference { get; init; }
    }
}
