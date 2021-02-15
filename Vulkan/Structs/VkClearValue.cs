

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkClearValue
    {
        [field: FieldOffset(0)]
        public VkClearColorValue Color { get; init; }

        [field: FieldOffset(0)]
        public VkClearDepthStencilValue DepthStencil { get; init; }
    }
}
