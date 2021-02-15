using System.Runtime.InteropServices;
namespace Vulkan.Handles
{
    namespace Amd { }
    namespace Google { }
    namespace Nintendo { }
    [StructLayout(LayoutKind.Sequential)] public struct VkBuffer { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkBufferView { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkCommandBuffer { public ulong RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkCommandPool { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkDescriptorPool { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkDescriptorSet { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkDescriptorSetLayout { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkDescriptorUpdateTemplate { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkDevice { public ulong RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkDeviceMemory { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkEvent { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkFence { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkFramebuffer { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkImage { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkImageView { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkInstance { public ulong RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkPhysicalDevice { public ulong RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkPipeline { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkPipelineCache { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkPipelineLayout { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkQueryPool { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkQueue { public ulong RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkRenderPass { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkSampler { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkSamplerYcbcrConversion { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkSemaphore { public nint RawValue { get; init; } }
    [StructLayout(LayoutKind.Sequential)] public struct VkShaderModule { public nint RawValue { get; init; } }
    namespace Nvidia
    {
        [StructLayout(LayoutKind.Sequential)] public struct VkAccelerationStructure { public nint RawValue { get; init; } }
        [StructLayout(LayoutKind.Sequential)] public struct VkObjectTableNVX { public nint RawValue { get; init; } }
        namespace Experimental
        {
            [StructLayout(LayoutKind.Sequential)] public struct VkIndirectCommandsLayout { public nint RawValue { get; init; } }
            [StructLayout(LayoutKind.Sequential)] public struct VkObjectTable { public nint RawValue { get; init; } }
        }
    }
    namespace Intel
    {
        [StructLayout(LayoutKind.Sequential)] public struct VkPerformanceConfiguration { public nint RawValue { get; init; } }
    }
    namespace Extension
    {
        [StructLayout(LayoutKind.Sequential)] public struct VkDebugReportCallback { public nint RawValue { get; init; } }
        [StructLayout(LayoutKind.Sequential)] public struct VkDebugUtilsMessenger { public nint RawValue { get; init; } }
        [StructLayout(LayoutKind.Sequential)] public struct VkValidationCache { public nint RawValue { get; init; } }
    }
    namespace Khronos
    {
        [StructLayout(LayoutKind.Sequential)] public struct VkDisplay { public nint RawValue { get; init; } }
        [StructLayout(LayoutKind.Sequential)] public struct VkDisplayMode { public nint RawValue { get; init; } }
        [StructLayout(LayoutKind.Sequential)] public struct VkSurface { public nint RawValue { get; init; } }
        [StructLayout(LayoutKind.Sequential)] public struct VkSwapchain { public nint RawValue { get; init; } }
    }
}
