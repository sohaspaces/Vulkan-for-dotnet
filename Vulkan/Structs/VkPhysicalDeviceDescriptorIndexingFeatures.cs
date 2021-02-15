

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceDescriptorIndexingFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 ShaderInputAttachmentArrayDynamicIndexing { get; init; }

        public VkBool32 ShaderUniformTexelBufferArrayDynamicIndexing { get; init; }

        public VkBool32 ShaderStorageTexelBufferArrayDynamicIndexing { get; init; }

        public VkBool32 ShaderUniformBufferArrayNonUniformIndexing { get; init; }

        public VkBool32 ShaderSampledImageArrayNonUniformIndexing { get; init; }

        public VkBool32 ShaderStorageBufferArrayNonUniformIndexing { get; init; }

        public VkBool32 ShaderStorageImageArrayNonUniformIndexing { get; init; }

        public VkBool32 ShaderInputAttachmentArrayNonUniformIndexing { get; init; }

        public VkBool32 ShaderUniformTexelBufferArrayNonUniformIndexing { get; init; }

        public VkBool32 ShaderStorageTexelBufferArrayNonUniformIndexing { get; init; }

        public VkBool32 DescriptorBindingUniformBufferUpdateAfterBind { get; init; }

        public VkBool32 DescriptorBindingSampledImageUpdateAfterBind { get; init; }

        public VkBool32 DescriptorBindingStorageImageUpdateAfterBind { get; init; }

        public VkBool32 DescriptorBindingStorageBufferUpdateAfterBind { get; init; }

        public VkBool32 DescriptorBindingUniformTexelBufferUpdateAfterBind { get; init; }

        public VkBool32 DescriptorBindingStorageTexelBufferUpdateAfterBind { get; init; }

        public VkBool32 DescriptorBindingUpdateUnusedWhilePending { get; init; }

        public VkBool32 DescriptorBindingPartiallyBound { get; init; }

        public VkBool32 DescriptorBindingVariableDescriptorCount { get; init; }

        public VkBool32 RuntimeDescriptorArray { get; init; }
    }
}
