

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceDescriptorIndexingProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint MaxUpdateAfterBindDescriptorsInAllPools { get; init; }

        public VkBool32 ShaderUniformBufferArrayNonUniformIndexingNative { get; init; }

        public VkBool32 ShaderSampledImageArrayNonUniformIndexingNative { get; init; }

        public VkBool32 ShaderStorageBufferArrayNonUniformIndexingNative { get; init; }

        public VkBool32 ShaderStorageImageArrayNonUniformIndexingNative { get; init; }

        public VkBool32 ShaderInputAttachmentArrayNonUniformIndexingNative { get; init; }

        public VkBool32 RobustBufferAccessUpdateAfterBind { get; init; }

        public VkBool32 QuadDivergentImplicitLod { get; init; }

        public uint MaxPerStageDescriptorUpdateAfterBindSamplers { get; init; }

        public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers { get; init; }

        public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers { get; init; }

        public uint MaxPerStageDescriptorUpdateAfterBindSampledImages { get; init; }

        public uint MaxPerStageDescriptorUpdateAfterBindStorageImages { get; init; }

        public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments { get; init; }

        public uint MaxPerStageUpdateAfterBindResources { get; init; }

        public uint MaxDescriptorSetUpdateAfterBindSamplers { get; init; }

        public uint MaxDescriptorSetUpdateAfterBindUniformBuffers { get; init; }

        public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic { get; init; }

        public uint MaxDescriptorSetUpdateAfterBindStorageBuffers { get; init; }

        public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic { get; init; }

        public uint MaxDescriptorSetUpdateAfterBindSampledImages { get; init; }

        public uint MaxDescriptorSetUpdateAfterBindStorageImages { get; init; }

        public uint MaxDescriptorSetUpdateAfterBindInputAttachments { get; init; }
    }
}
