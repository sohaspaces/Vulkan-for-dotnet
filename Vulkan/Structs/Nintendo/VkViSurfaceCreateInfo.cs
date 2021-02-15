

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Nintendo;
namespace Vulkan.Structs.Nintendo
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkViSurfaceCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkViSurfaceCreateFlags Flags { get; init; }

        public unsafe void* Window { get; init; }
    }
}
