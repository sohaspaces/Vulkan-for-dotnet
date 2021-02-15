

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentSampleLocations
    {
        public uint AttachmentIndex { get; init; }

        public VkSampleLocationsInfo SampleLocationsInfo { get; init; }
    }
}
