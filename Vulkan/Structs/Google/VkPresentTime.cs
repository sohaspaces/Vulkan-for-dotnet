

using System.Runtime.InteropServices;
namespace Vulkan.Structs.Google
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPresentTime
    {
        public uint PresentID { get; init; }

        public ulong DesiredPresentTime { get; init; }
    }
}
