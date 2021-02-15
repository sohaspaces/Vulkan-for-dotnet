namespace Vulkan.Enums
{
    public enum VkQueryPipelineStatisticFlags
    {
        InputAssemblyVertices = 0x00000001,
        InputAssemblyPrimitives = 0x00000002,
        VertexShaderInvocations = 0x00000004,
        GeometryShaderInvocations = 0x00000008,
        GeometryShaderPrimitives = 0x00000010,
        ClippingInvocations = 0x00000020,
        ClippingPrimitives = 0x00000040,
        FragmentShaderInvocations = 0x00000080,
        TessellationControlShaderPatches = 0x00000100,
        TessellationEvaluationShaderInvocations = 0x00000200,
        ComputeShaderInvocations = 0x00000400
    }
}
