namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkMemoryPropertyFlags
    {
        DeviceLocal = 0x00000001,
        HostVisible = 0x00000002,
        HostCoherent = 0x00000004,
        HostCached = 0x00000008,
        LazilyAllocated = 0x00000010,
        Protected = 0x00000020,
        DeviceCoherentAmd = 0x00000040,
        DeviceUncachedAmd = 0x00000080
    }
}
