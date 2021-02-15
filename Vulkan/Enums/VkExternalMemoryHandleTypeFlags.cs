namespace Vulkan.Enums
{
    public enum VkExternalMemoryHandleTypeFlags
    {
        OpaqueFd = 0x00000001,
        OpaqueWin32 = 0x00000002,
        OpaqueWin32Kmd = 0x00000004,
        OpaqueD3D11Texture = 0x00000008,
        OpaqueD3D11TextureKmd = 0x00000010,
        OpaqueD3D11Heap = 0x00000020,
        OpaqueD3D11Resource = 0x00000040,
        DmaBufExt = 0x00000200,
        AndroidHardwareBuffer = 0x00000400,
        HostAllocation = 0x00000080,
        HostMappedForeignMemory = 0x00000100,
    }
}
