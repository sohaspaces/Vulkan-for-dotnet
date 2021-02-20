namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkExternalFenceHandleTypeFlags
    {
        OpaqueFd = 0x00000001,
        OpaqueWin32 = 0x00000002,
        OpaqueWin32Kmd = 0x00000004,
        SyncFd = 0x00000008
    }
}
