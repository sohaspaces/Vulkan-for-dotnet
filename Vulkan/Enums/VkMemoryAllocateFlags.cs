namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkMemoryAllocateFlags
    {
        DeviceMask = 0x00000001,
        DeviceAddress = 0x00000002,
        DeviceAddressCaptureReplay = 0x00000004
    }
}
