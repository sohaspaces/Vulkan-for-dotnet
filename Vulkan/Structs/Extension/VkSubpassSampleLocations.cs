

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassSampleLocations
    {
        public uint SubpassIndex { get; init; }

        public VkSampleLocationsInfo SampleLocationsInfo { get; init; }
    }
}
