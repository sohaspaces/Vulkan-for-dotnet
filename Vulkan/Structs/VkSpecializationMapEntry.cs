using System.Runtime.InteropServices;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSpecializationMapEntry
    {
        public uint ConstantID { get; init; }

        public uint Offset { get; init; }



        public nuint Size { get; init; }
    }
}
