

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugMarkerObjectNameInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDebugReportObjectType ObjectType { get; init; }

        public ulong Object { get; init; }

        public unsafe byte* ObjectName { get; init; }
    }
}
