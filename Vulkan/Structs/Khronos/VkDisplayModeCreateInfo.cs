

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Khronos;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayModeCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDisplayModeCreateFlags Flags { get; init; }

        public VkDisplayModeParameters Parameters { get; init; }
    }
}
