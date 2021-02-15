

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceDepthStencilResolveProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkResolveModeFlags SupportedDepthResolveModes { get; init; }

        public VkResolveModeFlags SupportedStencilResolveModes { get; init; }

        public VkBool32 IndependentResolveNone { get; init; }

        public VkBool32 IndependentResolve { get; init; }
    }
}
