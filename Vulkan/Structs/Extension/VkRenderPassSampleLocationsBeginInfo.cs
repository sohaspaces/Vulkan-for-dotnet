

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRenderPassSampleLocationsBeginInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint AttachmentInitialSampleLocationsCount { get; init; }

        public unsafe VkAttachmentSampleLocations* AttachmentInitialSampleLocations { get; init; }

        public uint PostSubpassSampleLocationsCount { get; init; }

        public unsafe VkSubpassSampleLocations* PostSubpassSampleLocations { get; init; }
    }
}
