

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageViewASTCDecodeMode
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkFormat DecodeMode { get; init; }
    }
}
