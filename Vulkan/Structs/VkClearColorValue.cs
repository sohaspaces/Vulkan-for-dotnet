using System.Runtime.InteropServices;

namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkClearColorValue
    {
        [field: FieldOffset(0)]
        public UnmanagedArray4<float> Float32 { get; set; }

        [field: FieldOffset(0)]
        public UnmanagedArray4<int> Int32 { get; set; }

        [field: FieldOffset(0)]
        public UnmanagedArray4<uint> UInt32 { get; set; }
    }
}
