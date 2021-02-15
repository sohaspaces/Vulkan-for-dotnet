

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Amd
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkShaderStatisticsInfo
    {
        public VkShaderStageFlags ShaderStageMask { get; init; }

        public VkShaderResourceUsage ResourceUsage { get; init; }

        public uint NumPhysicalVgprs { get; init; }

        public uint NumPhysicalSgprs { get; init; }

        public uint NumAvailableVgprs { get; init; }

        public uint NumAvailableSgprs { get; init; }

        public UnmanagedArray3<uint> ComputeWorkGroupSize { get; init; }
    }
}
