

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrawMeshTasksIndirectCommand
    {
        public uint TaskCount { get; init; }

        public uint FirstTask { get; init; }
    }
}
