

using System.Runtime.InteropServices;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseBufferMemoryBindInfo
    {
        public VkBuffer Buffer { get; init; }

        public uint BindCount { get; init; }

        public unsafe VkSparseMemoryBind* Binds { get; init; }
    }
}
