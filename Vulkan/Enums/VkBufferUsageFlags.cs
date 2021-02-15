namespace Vulkan.Enums
{
    public enum VkBufferUsageFlags
    {
        TransferSrc = 0x00000001,
        TransferDst = 0x00000002,
        UniformTexelBuffer = 0x00000004,
        StorageTexelBuffer = 0x00000008,
        UniformBuffer = 0x00000010,
        StorageBuffer = 0x00000020,
        IndexBuffer = 0x00000040,
        VertexBuffer = 0x00000080,
        IndirectBuffer = 0x00000100,
        ShaderDeviceAddress = 0x00020000,
        TransformFeedbackBufferExt = 0x00000800,
        TransformFeedbackCounterBufferExt = 0x00001000,
        ConditionalRenderingExt = 0x00000200,
        RayTracingNv = 0x00000400
    }
}
