

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevice8BitStorageFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 StorageBuffer8BitAccess { get; init; }

        public VkBool32 UniformAndStorageBuffer8BitAccess { get; init; }

        public VkBool32 StoragePushConstant8 { get; init; }
    }
}
