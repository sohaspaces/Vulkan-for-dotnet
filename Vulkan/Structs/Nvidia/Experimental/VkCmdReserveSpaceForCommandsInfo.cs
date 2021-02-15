

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles.Nvidia.Experimental;
namespace Vulkan.Structs.Nvidia.Experimental
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCmdReserveSpaceForCommandsInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkObjectTable ObjectTable { get; init; }

        public VkIndirectCommandsLayout IndirectCommandsLayout { get; init; }

        public uint MaxSequencesCount { get; init; }
    }
}
