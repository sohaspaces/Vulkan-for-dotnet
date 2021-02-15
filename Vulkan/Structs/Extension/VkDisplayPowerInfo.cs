

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPowerInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDisplayPowerState PowerState { get; init; }
    }
}
