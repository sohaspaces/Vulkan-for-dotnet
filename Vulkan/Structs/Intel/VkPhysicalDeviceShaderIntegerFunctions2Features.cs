

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Intel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderIntegerFunctions2Features
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 ShaderIntegerFunctions2 { get; init; }
    }
}
