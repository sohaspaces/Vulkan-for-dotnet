

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalImageFormatProperties
    {
        public VkImageFormatProperties ImageFormatProperties { get; init; }

        public VkExternalMemoryFeatureFlags ExternalMemoryFeatures { get; init; }

        public VkExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes { get; init; }

        public VkExternalMemoryHandleTypeFlags CompatibleHandleTypes { get; init; }
    }
}
