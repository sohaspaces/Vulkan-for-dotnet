using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBaseInStructure
    {
        public VkStructureType StructureType { get; init; }



        public nint Next { get; init; }
    }
}
