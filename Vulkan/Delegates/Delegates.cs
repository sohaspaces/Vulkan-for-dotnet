using Vulkan.Enums;
using Vulkan.Enums.Extension;
using Vulkan.Structs.Extension;

namespace Vulkan.Delegates
{
    public unsafe delegate void* VkAllocationFunction
    (
        void* userDataRef,
        nuint size,
        nuint allignment,
        VkSystemAllocationScope scope
    );

    public unsafe delegate void VkFreeFunction
    (
        void* userData,
        void* memory
    );

    public unsafe delegate void VkInternalAllocationNotification
    (
        void* pUserData,
        nuint size,
        VkInternalAllocationType allocationType,
        VkSystemAllocationScope allocationScope
    );

    public unsafe delegate void VkInternalFreeNotification
    (
        void* pUserData,
        nuint size,
        VkInternalAllocationType allocationType,
        VkSystemAllocationScope allocationScope
    );

    public unsafe delegate void* VkReallocationFunction
    (
        void* pUserData,
        void* pOriginal,
        nuint size,
        nuint alignment,
        VkSystemAllocationScope allocationScope
    );

    public unsafe delegate void VkVoidFunction();

    namespace Extension
    {
        public unsafe delegate VkBool32 VkDebugReportCallback
        (
            VkDebugReportFlags flags,
            VkDebugReportObjectType objectType,
            ulong @object,
            nuint location,
            int messageCode,
            string layerPrefix,
            string message,
            void* userData
        );

        public unsafe delegate VkBool32 VkDebugUtilsMessengerCallback
        (
            VkDebugUtilsMessageSeverityFlags severity,
            VkDebugUtilsMessengerCallbackData* callbackData,
            void* userData
        );
    }
}
