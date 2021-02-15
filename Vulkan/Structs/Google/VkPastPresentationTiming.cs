

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Google
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPastPresentationTiming
    {
        public uint PresentID { get; init; }

        public ulong DesiredPresentTime { get; init; }

        public ulong ActualPresentTime { get; init; }

        public ulong EarliestPresentTime { get; init; }

        public ulong PresentMargin { get; init; }
    }
}
