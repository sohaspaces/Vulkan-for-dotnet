namespace Vulkan.Enums
{
    public enum VkExternalSemaphoreHandleTypeFlags
    {
        OpaqueFd = 0x00000001,
        OpaqueWin32 = 0x00000002,
        OpaqueWin32Kmd = 0x00000004,
        D3D12Fence = 0x00000008,
        SyncFd = 0x00000010
    }
}
