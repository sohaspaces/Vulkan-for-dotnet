using Vulkan.Enums;
namespace Vulkan.Structs
{
    public struct VkPhysicalDeviceProperties
    {
        public uint ApiVersion { get; init; }
        public uint DriverVersion { get; init; }
        public uint VendorId { get; init; }
        public uint DeviceId { get; init; }
        public VkPhysicalDeviceType DeviceType { get; init; }
        public UnmanagedString256 DeviceName { get; init; }
        public UnmanagedArray16<uint> PipelineCacheUuid { get; init; }
        public VkPhysicalDeviceLimits Limits { get; init; }
        public VkPhysicalDeviceSparseProperties SparseProperties { get; init; }
    }
}
