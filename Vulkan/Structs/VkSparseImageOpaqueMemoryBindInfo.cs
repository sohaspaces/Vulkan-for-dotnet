

using System.Runtime.InteropServices;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageOpaqueMemoryBindInfo
    {
        public VkImage Image { get; init; }

        public uint BindCount { get; init; }

        public unsafe VkSparseMemoryBind* Binds { get; init; }
    }
}
