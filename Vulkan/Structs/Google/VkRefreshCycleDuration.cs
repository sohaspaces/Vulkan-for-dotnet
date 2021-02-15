

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Google
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRefreshCycleDuration
    {
        public ulong RefreshDuration { get; init; }
    }
}
