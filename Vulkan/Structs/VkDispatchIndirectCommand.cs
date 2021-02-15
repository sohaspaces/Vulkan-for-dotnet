

using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDispatchIndirectCommand
    {
        public uint X { get; init; }

        public uint Y { get; init; }

        public uint Z { get; init; }
    }
}
