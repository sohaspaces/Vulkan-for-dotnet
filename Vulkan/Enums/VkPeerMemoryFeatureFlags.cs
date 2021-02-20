namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkPeerMemoryFeatureFlags
    {
        CopySrc = 0x00000001,
        CopyDst = 0x00000002,
        GenericSrc = 0x00000004,
        GenericDst = 0x00000008
    }
}
