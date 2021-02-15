

using System.Runtime.InteropServices;
using Vulkan.Enums.Nvidia.Experimental;
using Vulkan.Handles;
namespace Vulkan.Structs.Nvidia.Experimental
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkIndirectCommandsToken
    {
        public VkIndirectCommandsTokenType TokenType { get; init; }

        public VkBuffer Buffer { get; init; }

        public VkDeviceSize Offset { get; init; }
    }
}
