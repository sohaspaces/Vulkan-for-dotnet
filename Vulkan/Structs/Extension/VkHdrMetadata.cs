

using System.Runtime.InteropServices;
using Vulkan.Enums;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkHdrMetadata
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkXYColor DisplayPrimaryRed { get; init; }

        public VkXYColor DisplayPrimaryGreen { get; init; }

        public VkXYColor DisplayPrimaryBlue { get; init; }

        public VkXYColor WhitePoint { get; init; }

        public float MaxLuminance { get; init; }

        public float MinLuminance { get; init; }

        public float MaxContentLightLevel { get; init; }

        public float MaxFrameAverageLightLevel { get; init; }
    }
}
