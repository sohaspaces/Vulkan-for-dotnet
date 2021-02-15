namespace Vulkan.Enums.Nvidia
{
    public enum VkBuildAccelerationStructureFlags
    {
        AllowUpdate = 0x00000001,
        AllowCompaction = 0x00000002,
        PreferFastTrace = 0x00000004,
        PreferFastBuild = 0x00000008,
        LowMemory = 0x00000010
    }
}
