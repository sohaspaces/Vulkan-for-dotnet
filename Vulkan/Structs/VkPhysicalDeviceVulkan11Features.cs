

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVulkan11Features
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 StorageBuffer16BitAccess { get; init; }

        public VkBool32 UniformAndStorageBuffer16BitAccess { get; init; }

        public VkBool32 StoragePushConstant16 { get; init; }

        public VkBool32 StorageInputOutput16 { get; init; }

        public VkBool32 Multiview { get; init; }

        public VkBool32 MultiviewGeometryShader { get; init; }

        public VkBool32 MultiviewTessellationShader { get; init; }

        public VkBool32 VariablePointersStorageBuffer { get; init; }

        public VkBool32 VariablePointers { get; init; }

        public VkBool32 ProtectedMemory { get; init; }

        public VkBool32 SamplerYcbcrConversion { get; init; }

        public VkBool32 ShaderDrawParameters { get; init; }
    }
}
