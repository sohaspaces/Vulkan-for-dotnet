using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugMarkerObjectTagInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDebugReportObjectType ObjectType { get; init; }

        public ulong Object { get; init; }

        public ulong TagName { get; init; }



        public nuint TagSize { get; init; }

        public unsafe void* Tag { get; init; }
    }
}
