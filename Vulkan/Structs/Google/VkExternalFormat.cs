

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Google
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalFormat
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public ulong ExternalFormat { get; init; }
    }
}
