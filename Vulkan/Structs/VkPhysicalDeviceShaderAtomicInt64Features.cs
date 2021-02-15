

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderAtomicInt64Features
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 ShaderBufferInt64Atomics { get; init; }

        public VkBool32 ShaderSharedInt64Atomics { get; init; }
    }
}
