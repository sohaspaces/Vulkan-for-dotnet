

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Khronos
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkPerformanceCounterResult
    {
        [field: FieldOffset(0)]
        public int Int32 { get; init; }

        [field: FieldOffset(0)]
        public uint UInt32 { get; init; }

        [field: FieldOffset(0)]
        public long Int64 { get; init; }

        [field: FieldOffset(0)]
        public ulong UInt64 { get; init; }

        [field: FieldOffset(0)]
        public float Float32 { get; init; }

        [field: FieldOffset(0)]
        public double Float64 { get; init; }
    }
}
