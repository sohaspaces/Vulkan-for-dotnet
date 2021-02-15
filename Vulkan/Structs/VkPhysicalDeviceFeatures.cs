

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFeatures
    {
        public VkBool32 RobustBufferAccess { get; init; }

        public VkBool32 FullDrawIndexUint32 { get; init; }

        public VkBool32 ImageCubeArray { get; init; }

        public VkBool32 IndependentBlend { get; init; }

        public VkBool32 GeometryShader { get; init; }

        public VkBool32 TessellationShader { get; init; }

        public VkBool32 SampleRateShading { get; init; }

        public VkBool32 DualSrcBlend { get; init; }

        public VkBool32 LogicOp { get; init; }

        public VkBool32 MultiDrawIndirect { get; init; }

        public VkBool32 DrawIndirectFirstInstance { get; init; }

        public VkBool32 DepthClamp { get; init; }

        public VkBool32 DepthBiasClamp { get; init; }

        public VkBool32 FillModeNonSolid { get; init; }

        public VkBool32 DepthBounds { get; init; }

        public VkBool32 WideLines { get; init; }

        public VkBool32 LargePoints { get; init; }

        public VkBool32 AlphaToOne { get; init; }

        public VkBool32 MultiViewport { get; init; }

        public VkBool32 SamplerAnisotropy { get; init; }

        public VkBool32 TextureCompressionETC2 { get; init; }

        public VkBool32 TextureCompressionASTC_LDR { get; init; }

        public VkBool32 TextureCompressionBC { get; init; }

        public VkBool32 OcclusionQueryPrecise { get; init; }

        public VkBool32 PipelineStatisticsQuery { get; init; }

        public VkBool32 VertexPipelineStoresAndAtomics { get; init; }

        public VkBool32 FragmentStoresAndAtomics { get; init; }

        public VkBool32 ShaderTessellationAndGeometryPointSize { get; init; }

        public VkBool32 ShaderImageGatherExtended { get; init; }

        public VkBool32 ShaderStorageImageExtendedFormats { get; init; }

        public VkBool32 ShaderStorageImageMultisample { get; init; }

        public VkBool32 ShaderStorageImageReadWithoutFormat { get; init; }

        public VkBool32 ShaderStorageImageWriteWithoutFormat { get; init; }

        public VkBool32 ShaderUniformBufferArrayDynamicIndexing { get; init; }

        public VkBool32 ShaderSampledImageArrayDynamicIndexing { get; init; }

        public VkBool32 ShaderStorageBufferArrayDynamicIndexing { get; init; }

        public VkBool32 ShaderStorageImageArrayDynamicIndexing { get; init; }

        public VkBool32 ShaderClipDistance { get; init; }

        public VkBool32 ShaderCullDistance { get; init; }

        public VkBool32 ShaderFloat64 { get; init; }

        public VkBool32 ShaderInt64 { get; init; }

        public VkBool32 ShaderInt16 { get; init; }

        public VkBool32 ShaderResourceResidency { get; init; }

        public VkBool32 ShaderResourceMinLod { get; init; }

        public VkBool32 SparseBinding { get; init; }

        public VkBool32 SparseResidencyBuffer { get; init; }

        public VkBool32 SparseResidencyImage2D { get; init; }

        public VkBool32 SparseResidencyImage3D { get; init; }

        public VkBool32 SparseResidency2Samples { get; init; }

        public VkBool32 SparseResidency4Samples { get; init; }

        public VkBool32 SparseResidency8Samples { get; init; }

        public VkBool32 SparseResidency16Samples { get; init; }

        public VkBool32 SparseResidencyAliased { get; init; }

        public VkBool32 VariableMultisampleRate { get; init; }

        public VkBool32 InheritedQueries { get; init; }
    }
}
