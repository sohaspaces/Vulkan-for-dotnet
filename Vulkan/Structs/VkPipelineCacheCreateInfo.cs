using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCacheCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkPipelineCacheCreateFlags Flags { get; init; }



        public nuint InitialDataSize { get; init; }

        public unsafe void* InitialData { get; init; }
    }
}
