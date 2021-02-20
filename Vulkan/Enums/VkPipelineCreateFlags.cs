namespace Vulkan.Enums
{
    [System.Flags]
    public enum VkPipelineCreateFlags
    {
        DisableOptimization = 0x00000001,
        AllowDerivatives = 0x00000002,
        Derivative = 0x00000004,
        ViewIndexFromDeviceIndex = 0x00000008,
        DispatchBase = 0x00000010,
        DeferCompileNv = 0x00000020,
        CaptureStatisticsKhr = 0x00000040,
        CaptureInternalRepresentationsKhr = 0x00000080
    }
}
