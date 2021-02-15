using System.Runtime.InteropServices;
using Vulkan.Delegates;
namespace Vulkan.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAllocationCallbacks
    {
        public unsafe void* UserData { get; init; }

        private nint allocationMethod;

        public VkAllocationFunction AllocationMethod
        {
            get => Marshal.GetDelegateForFunctionPointer<VkAllocationFunction>(allocationMethod);
            init => allocationMethod = Marshal.GetFunctionPointerForDelegate(value);
        }

        private nint reallocationMethod;

        public VkReallocationFunction ReallocationMethod
        {
            get => Marshal.GetDelegateForFunctionPointer<VkReallocationFunction>(reallocationMethod);
            init => reallocationMethod = Marshal.GetFunctionPointerForDelegate(value);
        }


        private nint freeMethod;

        public VkFreeFunction FreeMethod
        {
            get => Marshal.GetDelegateForFunctionPointer<VkFreeFunction>(freeMethod);
            init => freeMethod = Marshal.GetFunctionPointerForDelegate(value);
        }


        private nint internalAllocationMethod;

        public VkInternalAllocationNotification InternalAllocationMethod
        {
            get => Marshal.GetDelegateForFunctionPointer<VkInternalAllocationNotification>(internalAllocationMethod);
            init => internalAllocationMethod = Marshal.GetFunctionPointerForDelegate(value);
        }


        private nint internalFreeMethod;

        public VkInternalFreeNotification InternalFreeMethod
        {
            get => Marshal.GetDelegateForFunctionPointer<VkInternalFreeNotification>(internalFreeMethod);
            init => internalFreeMethod = Marshal.GetFunctionPointerForDelegate(value);
        }

    }
}
