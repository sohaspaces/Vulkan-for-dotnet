

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrawIndexedIndirectCommand
    {
        public uint IndexCount { get; init; }

        public uint InstanceCount { get; init; }

        public uint FirstIndex { get; init; }

        public int VertexOffset { get; init; }

        public uint FirstInstance { get; init; }
    }
}
