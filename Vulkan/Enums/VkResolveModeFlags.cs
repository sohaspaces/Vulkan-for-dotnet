namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkResolveModeFlags
    {
        None = 0,
        SampleZero = 0x00000001,
        Average = 0x00000002,
        Min = 0x00000004,
        Max = 0x00000008
    }
}
