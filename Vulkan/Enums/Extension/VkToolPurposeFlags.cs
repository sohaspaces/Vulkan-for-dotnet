namespace Vulkan.Enums.Extension
{
    [System.Flags]
    public enum VkToolPurposeFlags
    {
        Validation = 0x00000001,
        Profiling = 0x00000002,
        Tracing = 0x00000004,
        AdditionalFeatures = 0x00000008,
        ModifyingFeatures = 0x00000010,
        DebugReporting = 0x00000020,
        DebugMarkers = 0x00000040
    }
}
