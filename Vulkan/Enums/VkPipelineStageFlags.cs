﻿namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkPipelineStageFlags
    {
        TopOfPipe = 0x00000001,
        DrawIndirect = 0x00000002,
        VertexInput = 0x00000004,
        VertexShader = 0x00000008,
        TessellationControlShader = 0x00000010,
        TessellationEvaluationShader = 0x00000020,
        GeometryShader = 0x00000040,
        FragmentShader = 0x00000080,
        EarlyFragmentTests = 0x00000100,
        LateFragmentTests = 0x00000200,
        ColorAttachmentOutput = 0x00000400,
        ComputeShader = 0x00000800,
        Transfer = 0x00001000,
        BottomOfPipe = 0x00002000,
        Host = 0x00004000,
        AllGraphics = 0x00008000,
        AllCommands = 0x00010000,
        TransformFeedbackExt = 0x01000000,
        ConditionalRenderingExt = 0x00040000,
        CommandProcessNvx = 0x00020000,
        ShadingRateImageNv = 0x00400000,
        RayTracingShaderNv = 0x00200000,
        AccelerationStructureBuildNv = 0x02000000,
        TaskShaderNv = 0x00080000,
        MeshShaderNv = 0x00100000,
        FragmentDensityProcessExt = 0x00800000
    }
}
