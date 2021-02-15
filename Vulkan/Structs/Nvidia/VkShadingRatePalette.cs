

using System.Runtime.InteropServices;
using Vulkan.Enums.Nvidia;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkShadingRatePalette
    {
        public uint ShadingRatePaletteEntryCount { get; init; }

        public unsafe VkShadingRatePaletteEntry* ShadingRatePaletteEntries { get; init; }
    }
}
