

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Handles;
namespace Vulkan.Structs.Nvidia
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkWin32KeyedMutexAcquireReleaseInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public uint AcquireCount { get; init; }

        public unsafe VkDeviceMemory* AcquireSyncs { get; init; }

        public unsafe ulong* AcquireKeys { get; init; }

        public unsafe uint* AcquireTimeoutMilliseconds { get; init; }

        public uint ReleaseCount { get; init; }

        public unsafe VkDeviceMemory* ReleaseSyncs { get; init; }

        public unsafe ulong* ReleaseKeys { get; init; }
    }
}
