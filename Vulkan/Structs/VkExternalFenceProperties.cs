

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalFenceProperties
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkExternalFenceHandleTypeFlags ExportFromImportedHandleTypes { get; init; }

        public VkExternalFenceHandleTypeFlags CompatibleHandleTypes { get; init; }

        public VkExternalFenceFeatureFlags ExternalFenceFeatures { get; init; }
    }
}
