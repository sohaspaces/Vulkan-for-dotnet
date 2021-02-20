namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkCommandPoolCreateFlags
    {
        Transient = 0x00000001,
        ResetCommandBuffer = 0x00000002,
        Protected = 0x00000004
    }
}
