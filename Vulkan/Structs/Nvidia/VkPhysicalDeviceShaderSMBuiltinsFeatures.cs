

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderSMBuiltinsFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 ShaderSMBuiltins { get; init; }
    }
}
