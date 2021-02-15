

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalSemaphoreProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkExternalSemaphoreHandleTypeFlags ExportFromImportedHandleTypes { get; init; }

        public VkExternalSemaphoreHandleTypeFlags CompatibleHandleTypes { get; init; }

        public VkExternalSemaphoreFeatureFlags ExternalSemaphoreFeatures { get; init; }
    }
}
