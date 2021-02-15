

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Amd
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayNativeHdrSurfaceCapabilities
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 LocalDimmingSupport { get; init; }
    }
}
