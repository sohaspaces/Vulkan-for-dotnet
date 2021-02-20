namespace Vulkan.Enums.Khronos
{
    [System.Flags]
    public enum VkDeviceGroupPresentModeFlags
    {
        Local = 0x00000001,
        Remote = 0x00000002,
        Sum = 0x00000004,
        LocalMultiDevice = 0x00000008
    }
}
