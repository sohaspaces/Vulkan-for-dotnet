using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugUtilsObjectTagInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkObjectType ObjectType { get; init; }

        public ulong ObjectHandle { get; init; }

        public ulong TagName { get; init; }



        public nuint TagSize { get; init; }

        public unsafe void* Tag { get; init; }
    }
}
