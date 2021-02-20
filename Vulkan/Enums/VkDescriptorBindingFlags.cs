namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkDescriptorBindingFlags
    {
        UpdateAfterBind = 0x00000001,
        UpdateUnusedWhilePending = 0x00000002,
        PartiallyBound = 0x00000004,
        VariableDescriptorCount = 0x00000008
    }
}
