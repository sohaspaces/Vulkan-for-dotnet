namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkImageAspectFlags
    {
        AspectColor = 0x00000001,
        AspectDepth = 0x00000002,
        AspectStencil = 0x00000004,
        AspectMetadata = 0x00000008,
        AspectPlane0 = 0x00000010,
        AspectPlane1 = 0x00000020,
        AspectPlane2 = 0x00000040,
        AspectMemoryPlane0Ext = 0x00000080,
        AspectMemoryPlane1Ext = 0x00000100,
        AspectMemoryPlane2Ext = 0x00000200,
        AspectMemoryPlane3Ext = 0x00000400
    }
}
