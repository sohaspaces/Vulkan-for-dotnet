using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineExecutableInternalRepresentation
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public UnmanagedString256 Name { get; init; }
        public UnmanagedString256 Description { get; init; }
        public VkBool32 IsText { get; init; }

        public nuint DataSize { get; init; }

        public unsafe void* Data { get; init; }
    }
}
