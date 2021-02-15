namespace Vulkan.Enums
{
    public enum VkSubgroupFeatureFlags
    {
        Basic = 0x00000001,
        Vote = 0x00000002,
        Arithmetic = 0x00000004,
        Ballot = 0x00000008,
        Shuffle = 0x00000010,
        ShuffleRelative = 0x00000020,
        Clustered = 0x00000040,
        Quad = 0x00000080,
        PartitionedNv = 0x00000100
    }
}
