namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkCullModeFlags
    {
        None = 0,
        Front = 0x00000001,
        Back = 0x00000002,
        FrontAndBack = 0x00000003
    }
}
