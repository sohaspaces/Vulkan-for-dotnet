

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalMemoryProperties
    {
        public VkExternalMemoryFeatureFlags ExternalMemoryFeatures { get; init; }

        public VkExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes { get; init; }

        public VkExternalMemoryHandleTypeFlags CompatibleHandleTypes { get; init; }
    }
}
