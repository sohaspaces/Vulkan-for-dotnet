

using System.Runtime.InteropServices;
using Vulkan.Enums.Nvidia.Experimental;
namespace Vulkan.Structs.Nvidia.Experimental
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkIndirectCommandsLayoutToken
    {
        public VkIndirectCommandsTokenType TokenType { get; init; }

        public uint BindingUnit { get; init; }

        public uint DynamicCount { get; init; }

        public uint Divisor { get; init; }
    }
}
