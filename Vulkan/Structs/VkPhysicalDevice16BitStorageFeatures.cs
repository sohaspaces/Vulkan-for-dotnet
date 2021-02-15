

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevice16BitStorageFeatures
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkBool32 StorageBuffer16BitAccess { get; init; }

        public VkBool32 UniformAndStorageBuffer16BitAccess { get; init; }

        public VkBool32 StoragePushConstant16 { get; init; }

        public VkBool32 StorageInputOutput16 { get; init; }
    }
}
