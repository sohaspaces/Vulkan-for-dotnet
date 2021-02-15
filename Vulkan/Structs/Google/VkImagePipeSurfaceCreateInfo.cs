using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Google;
namespace Vulkan.Structs.Google
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImagePipeSurfaceCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkImagePipeSurfaceCreateFlags Flags { get; init; }



        public nint ImagePipeHandle { get; init; }
    }
}
