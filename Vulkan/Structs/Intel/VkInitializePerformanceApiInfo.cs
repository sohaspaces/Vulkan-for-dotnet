

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Intel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkInitializePerformanceApiInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public unsafe void* UserData { get; init; }
    }
}
