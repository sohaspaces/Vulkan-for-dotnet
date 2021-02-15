using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkShaderModuleCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkShaderModuleCreateFlags Flags { get; init; }



        public nuint CodeSize { get; init; }

        public unsafe uint* Code { get; init; }
    }
}
