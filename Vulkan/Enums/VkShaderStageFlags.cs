namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkShaderStageFlags
    {
        Vertex = 0x00000001,
        TessellationControl = 0x00000002,
        TessellationEvaluation = 0x00000004,
        Geometry = 0x00000008,
        Fragment = 0x00000010,
        Compute = 0x00000020,
        AllGraphics = 0x0000001f,
        All = 0x7fffffff,
        RaygenNv = 0x00000100,
        AnyHitNv = 0x00000200,
        ClosestHitNv = 0x00000400,
        MissNv = 0x00000800,
        IntersectionNv = 0x00001000,
        CallableNv = 0x00002000,
        TaskNv = 0x00000040,
        MeshNv = 0x00000080
    }
}
