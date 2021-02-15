

using System.Runtime.InteropServices;
using Vulkan.Delegates.Extension;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
namespace Vulkan.Structs.Extension
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugReportCallbackCreateInfo
    {
        public VkStructureType StructureType { get; init; }

        public unsafe void* Next { get; init; }

        public VkDebugReportFlags Flags { get; init; }

        private nint callbackMethod;

        public VkDebugReportCallback CallbackMethod
        {
            get => Marshal.GetDelegateForFunctionPointer<VkDebugReportCallback>(callbackMethod);
            init => callbackMethod = Marshal.GetFunctionPointerForDelegate(value);
        }


        public unsafe void* UserData { get; init; }
    }
}
