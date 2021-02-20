namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkExternalMemoryFeatureFlags
    {
        DedicatedOnly = 0x00000001,
        Exportable = 0x00000002,
        Importable = 0x00000004
    }
}
