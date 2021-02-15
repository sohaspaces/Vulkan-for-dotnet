

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalBufferProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkExternalMemoryProperties ExternalMemoryProperties { get; init; }
    }
}
