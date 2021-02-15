

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorPoolCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDescriptorPoolCreateFlags Flags { get; init; }

        public uint MaxSets { get; init; }

        public uint PoolSizeCount { get; init; }

        public unsafe VkDescriptorPoolSize* PoolSizes { get; init; }
    }
}
