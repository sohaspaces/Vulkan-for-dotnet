﻿namespace Vulkan.Enums
{
    public enum VkObjectType
    {
        Unknown = 0,
        Instance = 1,
        PhysicalDevice = 2,
        Device = 3,
        Queue = 4,
        Semaphore = 5,
        CommandBuffer = 6,
        Fence = 7,
        DeviceMemory = 8,
        Buffer = 9,
        Image = 10,
        Event = 11,
        QueryPool = 12,
        BufferView = 13,
        ImageView = 14,
        ShaderModule = 15,
        PipelineCache = 16,
        PipelineLayout = 17,
        RenderPass = 18,
        Pipeline = 19,
        DescriptorSetLayout = 20,
        Sampler = 21,
        DescriptorPool = 22,
        DescriptorSet = 23,
        Framebuffer = 24,
        CommandPool = 25,
        SamplerYcbcrConversion = 1000156000,
        DescriptorUpdateTemplate = 1000085000,
        SurfaceKhr = 1000000000,
        SwapchainKhr = 1000001000,
        DisplayKhr = 1000002000,
        DisplayModeKhr = 1000002001,
        DebugReportCallbackExt = 1000011000,
        ObjectTableNvx = 1000086000,
        IndirectCommandsLayoutNvx = 1000086001,
        DebugUtilsMessengerExt = 1000128000,
        ValidationCacheExt = 1000160000,
        AccelerationStructureNv = 1000165000,
        PerformanceConfigurationIntel = 1000210000
    }
}