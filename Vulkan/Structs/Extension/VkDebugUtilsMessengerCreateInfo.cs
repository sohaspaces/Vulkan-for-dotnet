

using System.Runtime.InteropServices;
using Vulkan.Delegates.Extension;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugUtilsMessengerCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDebugUtilsMessengerCreateFlags Flags { get; init; }

        public VkDebugUtilsMessageSeverityFlags MessageSeverity { get; init; }

        public VkDebugUtilsMessageTypeFlags MessageType { get; init; }

        private nint userCallbackMethod;

        public VkDebugUtilsMessengerCallback UserCallbackMethod
        {
            get => Marshal.GetDelegateForFunctionPointer<VkDebugUtilsMessengerCallback>(userCallbackMethod);
            init => userCallbackMethod = Marshal.GetFunctionPointerForDelegate(value);
        }

        public unsafe void* UserData { get; init; }
    }
}
