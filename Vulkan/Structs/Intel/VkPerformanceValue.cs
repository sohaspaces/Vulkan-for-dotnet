

using System.Runtime.InteropServices;
using Vulkan.Enums.Intel;
namespace Vulkan.Structs.Intel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceValue
    {
        public VkPerformanceValueType Type { get; init; }

        public VkPerformanceValueData Data { get; init; }
    }
}
