

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Intel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceValueData
    {
        public uint Value32 { get; init; }

        public ulong Value64 { get; init; }

        public float ValueFloat { get; init; }

        public VkBool32 ValueBool { get; init; }

        public unsafe byte* ValueString { get; init; }
    }
}
