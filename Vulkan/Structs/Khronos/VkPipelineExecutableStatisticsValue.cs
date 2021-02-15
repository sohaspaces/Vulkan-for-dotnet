

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkPipelineExecutableStatisticsValue
    {
        [field: FieldOffset(0)]
        public VkBool32 B32 { get; init; }

        [field: FieldOffset(0)]
        public long I64 { get; init; }

        [field: FieldOffset(0)]
        public ulong U64 { get; init; }

        [field: FieldOffset(0)]
        public float F64 { get; init; }
    }
}
