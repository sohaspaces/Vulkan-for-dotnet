

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkShaderModuleValidationCacheCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkValidationCache ValidationCache { get; init; }
    }
}
