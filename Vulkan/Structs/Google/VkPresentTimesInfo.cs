

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Google
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPresentTimesInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint SwapchainCount { get; init; }

        public unsafe VkPresentTime* Times { get; init; }
    }
}
