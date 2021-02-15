

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugUtilsLabel
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public unsafe byte* LabelName { get; init; }

        public UnmanagedArray4<float> Color { get; init; }
    }
}
