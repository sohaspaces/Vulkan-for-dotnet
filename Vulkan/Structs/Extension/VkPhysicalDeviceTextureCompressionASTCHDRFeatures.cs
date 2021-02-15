

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 TextureCompressionASTC_HDR { get; init; }
    }
}
