

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSwapchainCounterCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkSurfaceCounterFlags SurfaceCounters { get; init; }
    }
}
