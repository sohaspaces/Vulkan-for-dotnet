namespace Vulkan.Enums.Nvidia.Experimental
{
    [System.Flags]
    public enum VkIndirectCommandsLayoutUsageFlags
    {
        UnorderedSequences = 0x00000001,
        SparseSequences = 0x00000002,
        EmptyExecutions = 0x00000004,
        IndexedSequences = 0x00000008
    }
}
