

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrawIndirectCommand
    {
        public uint VertexCount { get; init; }

        public uint InstanceCount { get; init; }

        public uint FirstVertex { get; init; }

        public uint FirstInstance { get; init; }
    }
}
