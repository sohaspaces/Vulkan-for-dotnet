

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVulkan12Features
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 SamplerMirrorClampToEdge { get; init; }

        public VkBool32 DrawIndirectCount { get; init; }

        public VkBool32 StorageBuffer8BitAccess { get; init; }

        public VkBool32 UniformAndStorageBuffer8BitAccess { get; init; }

        public VkBool32 StoragePushConstant8 { get; init; }

        public VkBool32 ShaderBufferInt64Atomics { get; init; }

        public VkBool32 ShaderSharedInt64Atomics { get; init; }

        public VkBool32 ShaderFloat16 { get; init; }

        public VkBool32 ShaderInt8 { get; init; }

        public VkBool32 DescriptorIndexing { get; init; }

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

        public VkBool32 SamplerFilterMinmax { get; init; }

        public VkBool32 ScalarBlockLayout { get; init; }

        public VkBool32 ImagelessFramebuffer { get; init; }

        public VkBool32 UniformBufferStandardLayout { get; init; }

        public VkBool32 ShaderSubgroupExtendedTypes { get; init; }

        public VkBool32 SeparateDepthStencilLayouts { get; init; }

        public VkBool32 HostQueryReset { get; init; }

        public VkBool32 TimelineSemaphore { get; init; }

        public VkBool32 BufferDeviceAddress { get; init; }

        public VkBool32 BufferDeviceAddressCaptureReplay { get; init; }

        public VkBool32 BufferDeviceAddressMultiDevice { get; init; }

        public VkBool32 VulkanMemoryModel { get; init; }

        public VkBool32 VulkanMemoryModelDeviceScope { get; init; }

        public VkBool32 VulkanMemoryModelAvailabilityVisibilityChains { get; init; }

        public VkBool32 ShaderOutputViewportIndex { get; init; }

        public VkBool32 ShaderOutputLayer { get; init; }

        public VkBool32 SubgroupBroadcastDynamicId { get; init; }
    }
}
