

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineShaderStageCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineShaderStageCreateFlags Flags { get; init; }

        public VkShaderStageFlags Stage { get; init; }

        public VkShaderModule Module { get; init; }

        public unsafe byte* Name { get; init; }

        public unsafe VkSpecializationInfo* SpecializationInfo { get; init; }
    }
}
