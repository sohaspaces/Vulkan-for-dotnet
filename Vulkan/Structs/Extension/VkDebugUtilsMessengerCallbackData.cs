

using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugUtilsMessengerCallbackData
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDebugUtilsMessengerCallbackDataFlags Flags { get; init; }

        public unsafe byte* MessageIdName { get; init; }

        public int MessageIdNumber { get; init; }

        public unsafe byte* Message { get; init; }

        public uint QueueLabelCount { get; init; }

        public unsafe VkDebugUtilsLabel* QueueLabels { get; init; }

        public uint CmdBufLabelCount { get; init; }

        public unsafe VkDebugUtilsLabel* CmdBufLabels { get; init; }

        public uint ObjectCount { get; init; }

        public unsafe VkDebugUtilsObjectNameInfo* Objects { get; init; }
    }
}
