

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceQuerySubmitInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint CounterPassIndex { get; init; }
    }
}
