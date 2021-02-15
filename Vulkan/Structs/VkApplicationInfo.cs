

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkApplicationInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public unsafe byte* ApplicationName { get; init; }

        public uint ApplicationVersion { get; init; }

        public unsafe byte* EngineName { get; init; }

        public uint EngineVersion { get; init; }

        public uint ApiVersion { get; init; }
    }
}
