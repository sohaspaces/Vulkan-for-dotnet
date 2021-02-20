namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkBufferCreateFlags
    {
        SparceBinding = 0x00000001,
        SparceResidency = 0x00000002,
        SparceAliased = 0x00000004,
        Protected = 0x00000008,
        DeviceAddressCaptureReplay = 0x00000010
    }
}
