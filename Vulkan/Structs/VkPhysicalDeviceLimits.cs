using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceLimits
    {
        public uint MaxImageDimension1D { get; init; }

        public uint MaxImageDimension2D { get; init; }

        public uint MaxImageDimension3D { get; init; }

        public uint MaxImageDimensionCube { get; init; }

        public uint MaxImageArrayLayers { get; init; }

        public uint MaxTexelBufferElements { get; init; }

        public uint MaxUniformBufferRange { get; init; }

        public uint MaxStorageBufferRange { get; init; }

        public uint MaxPushConstantsSize { get; init; }

        public uint MaxMemoryAllocationCount { get; init; }

        public uint MaxSamplerAllocationCount { get; init; }

        public VkDeviceSize BufferImageGranularity { get; init; }

        public VkDeviceSize SparseAddressSpaceSize { get; init; }

        public uint MaxBoundDescriptorSets { get; init; }

        public uint MaxPerStageDescriptorSamplers { get; init; }

        public uint MaxPerStageDescriptorUniformBuffers { get; init; }

        public uint MaxPerStageDescriptorStorageBuffers { get; init; }

        public uint MaxPerStageDescriptorSampledImages { get; init; }

        public uint MaxPerStageDescriptorStorageImages { get; init; }

        public uint MaxPerStageDescriptorInputAttachments { get; init; }

        public uint MaxPerStageResources { get; init; }

        public uint MaxDescriptorSetSamplers { get; init; }

        public uint MaxDescriptorSetUniformBuffers { get; init; }

        public uint MaxDescriptorSetUniformBuffersDynamic { get; init; }

        public uint MaxDescriptorSetStorageBuffers { get; init; }

        public uint MaxDescriptorSetStorageBuffersDynamic { get; init; }

        public uint MaxDescriptorSetSampledImages { get; init; }

        public uint MaxDescriptorSetStorageImages { get; init; }

        public uint MaxDescriptorSetInputAttachments { get; init; }

        public uint MaxVertexInputAttributes { get; init; }

        public uint MaxVertexInputBindings { get; init; }

        public uint MaxVertexInputAttributeOffset { get; init; }

        public uint MaxVertexInputBindingStride { get; init; }

        public uint MaxVertexOutputComponents { get; init; }

        public uint MaxTessellationGenerationLevel { get; init; }

        public uint MaxTessellationPatchSize { get; init; }

        public uint MaxTessellationControlPerVertexInputComponents { get; init; }

        public uint MaxTessellationControlPerVertexOutputComponents { get; init; }

        public uint MaxTessellationControlPerPatchOutputComponents { get; init; }

        public uint MaxTessellationControlTotalOutputComponents { get; init; }

        public uint MaxTessellationEvaluationInputComponents { get; init; }

        public uint MaxTessellationEvaluationOutputComponents { get; init; }

        public uint MaxGeometryShaderInvocations { get; init; }

        public uint MaxGeometryInputComponents { get; init; }

        public uint MaxGeometryOutputComponents { get; init; }

        public uint MaxGeometryOutputVertices { get; init; }

        public uint MaxGeometryTotalOutputComponents { get; init; }

        public uint MaxFragmentInputComponents { get; init; }

        public uint MaxFragmentOutputAttachments { get; init; }

        public uint MaxFragmentDualSrcAttachments { get; init; }

        public uint MaxFragmentCombinedOutputResources { get; init; }

        public uint MaxComputeSharedMemorySize { get; init; }

        public UnmanagedArray3<uint> MaxComputeWorkGroupCount { get; init; }

        public uint MaxComputeWorkGroupInvocations { get; init; }

        public UnmanagedArray3<uint> MaxComputeWorkGroupSize { get; init; }

        public uint SubPixelPrecisionBits { get; init; }

        public uint SubTexelPrecisionBits { get; init; }

        public uint MipmapPrecisionBits { get; init; }

        public uint MaxDrawIndexedIndexValue { get; init; }

        public uint MaxDrawIndirectCount { get; init; }

        public float MaxSamplerLodBias { get; init; }

        public float MaxSamplerAnisotropy { get; init; }

        public uint MaxViewports { get; init; }

        public UnmanagedArray2<uint> MaxViewportDimensions { get; init; }

        public UnmanagedArray2<float> ViewportBoundsRange { get; init; }

        public uint ViewportSubPixelBits { get; init; }



        public nuint MinMemoryMapAlignment { get; init; }

        public VkDeviceSize MinTexelBufferOffsetAlignment { get; init; }

        public VkDeviceSize MinUniformBufferOffsetAlignment { get; init; }

        public VkDeviceSize MinStorageBufferOffsetAlignment { get; init; }

        public int MinTexelOffset { get; init; }

        public uint MaxTexelOffset { get; init; }

        public int MinTexelGatherOffset { get; init; }

        public uint MaxTexelGatherOffset { get; init; }

        public float MinInterpolationOffset { get; init; }

        public float MaxInterpolationOffset { get; init; }

        public uint SubPixelInterpolationOffsetBits { get; init; }

        public uint MaxFramebufferWidth { get; init; }

        public uint MaxFramebufferHeight { get; init; }

        public uint MaxFramebufferLayers { get; init; }

        public VkSampleCountFlags FramebufferColorSampleCounts { get; init; }

        public VkSampleCountFlags FramebufferDepthSampleCounts { get; init; }

        public VkSampleCountFlags FramebufferStencilSampleCounts { get; init; }

        public VkSampleCountFlags FramebufferNoAttachmentsSampleCounts { get; init; }

        public uint MaxColorAttachments { get; init; }

        public VkSampleCountFlags SampledImageColorSampleCounts { get; init; }

        public VkSampleCountFlags SampledImageIntegerSampleCounts { get; init; }

        public VkSampleCountFlags SampledImageDepthSampleCounts { get; init; }

        public VkSampleCountFlags SampledImageStencilSampleCounts { get; init; }

        public VkSampleCountFlags StorageImageSampleCounts { get; init; }

        public uint MaxSampleMaskWords { get; init; }

        public VkBool32 TimestampComputeAndGraphics { get; init; }

        public float TimestampPeriod { get; init; }

        public uint MaxClipDistances { get; init; }

        public uint MaxCullDistances { get; init; }

        public uint MaxCombinedClipAndCullDistances { get; init; }

        public uint DiscreteQueuePriorities { get; init; }

        public UnmanagedArray2<float> PointSizeRange { get; init; }

        public UnmanagedArray2<float> LineWidthRange { get; init; }

        public float PointSizeGranularity { get; init; }

        public float LineWidthGranularity { get; init; }

        public VkBool32 StrictLines { get; init; }

        public VkBool32 StandardSampleLocations { get; init; }

        public VkDeviceSize OptimalBufferCopyOffsetAlignment { get; init; }

        public VkDeviceSize OptimalBufferCopyRowPitchAlignment { get; init; }

        public VkDeviceSize NonCoherentAtomSize { get; init; }
    }
}
