

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassEndInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }
    }
}
