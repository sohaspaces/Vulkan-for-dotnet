using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkValidationCacheCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkValidationCacheCreateFlags Flags { get; init; }



        public nuint InitialDataSize { get; init; }

        public unsafe void* InitialData { get; init; }
    }
}