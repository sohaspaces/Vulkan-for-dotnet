

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceCooperativeMatrixProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkShaderStageFlags CooperativeMatrixSupportedStages { get; init; }
    }
}
