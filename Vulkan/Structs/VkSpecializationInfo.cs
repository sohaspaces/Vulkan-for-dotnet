using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSpecializationInfo
    {
        public uint MapEntryCount { get; init; }

        public unsafe VkSpecializationMapEntry* MapEntries { get; init; }



        public nuint DataSize { get; init; }

        public unsafe void* Data { get; init; }
    }
}
