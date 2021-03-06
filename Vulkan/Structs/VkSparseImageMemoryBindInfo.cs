

using System.Runtime.InteropServices;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageMemoryBindInfo
    {
        public VkImage Image { get; init; }

        public uint BindCount { get; init; }

        public unsafe VkSparseImageMemoryBind* Binds { get; init; }
    }
}
