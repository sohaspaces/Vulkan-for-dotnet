using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
using Vulkan.Enums.Khronos;
using Vulkan.Handles;
using Vulkan.Handles.Extension;
using Vulkan.Handles.Khronos;
using Vulkan.Structs;
using Vulkan.Structs.Extension;
using Vulkan.Structs.Khronos;
namespace Vulkan
{
    public static unsafe class VkExt
    {
        [DllImport("vulkan-1")] private static extern VkResult vkAcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchain swapchain);
        public static void AcquireFullScreenExclusiveMode(VkDevice device, VkSwapchain swapchain) => vkAcquireFullScreenExclusiveModeEXT(device, swapchain).AssertSuccess(nameof(vkAcquireFullScreenExclusiveModeEXT));
        [DllImport("vulkan-1")] private static extern void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfo* conditionalRenderingBegin);
        public static void CmdBeginConditionalRendering(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfo* conditionalRenderingBegin) => vkCmdBeginConditionalRenderingEXT(commandBuffer, conditionalRenderingBegin);
        [DllImport("vulkan-1")] private static extern void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabel* labelInfo);
        public static void CmdBeginDebugUtilsLabel(VkCommandBuffer commandBuffer, VkDebugUtilsLabel* labelInfo) => vkCmdBeginDebugUtilsLabelEXT(commandBuffer, labelInfo);
        [DllImport("vulkan-1")] private static extern void vkCmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index);
        public static void CmdBeginQueryIndexed(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index) => vkCmdBeginQueryIndexedEXT(commandBuffer, queryPool, query, flags, index);
        [DllImport("vulkan-1")] private static extern void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* counterBuffers, VkDeviceSize* counterBufferOffsets);
        public static void CmdBeginTransformFeedback(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* counterBuffers, VkDeviceSize* counterBufferOffsets) => vkCmdBeginTransformFeedbackEXT(commandBuffer, firstCounterBuffer, counterBufferCount, counterBuffers, counterBufferOffsets);
        [DllImport("vulkan-1")] private static extern void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes);
        public static void CmdBindTransformFeedbackBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* buffers, VkDeviceSize* offsets, VkDeviceSize* sizes) => vkCmdBindTransformFeedbackBuffersEXT(commandBuffer, firstBinding, bindingCount, buffers, offsets, sizes);
        [DllImport("vulkan-1")] private static extern void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfo* markerInfo);
        public static void CmdDebugMarkerBegin(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfo* markerInfo) => vkCmdDebugMarkerBeginEXT(commandBuffer, markerInfo);
        [DllImport("vulkan-1")] private static extern void vkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer);
        public static void CmdDebugMarkerEnd(VkCommandBuffer commandBuffer) => vkCmdDebugMarkerEndEXT(commandBuffer);
        [DllImport("vulkan-1")] private static extern void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfo* markerInfo);
        public static void CmdDebugMarkerInsert(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfo* markerInfo) => vkCmdDebugMarkerInsertEXT(commandBuffer, markerInfo);
        [DllImport("vulkan-1")] private static extern void vkCmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, VkDeviceSize counterBufferOffset, uint counterOffset, uint vertexStride);
        public static void CmdDrawIndirectByteCount(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, VkDeviceSize counterBufferOffset, uint counterOffset, uint vertexStride) => vkCmdDrawIndirectByteCountEXT(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
        [DllImport("vulkan-1")] private static extern void vkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer);
        public static void CmdEndConditionalRendering(VkCommandBuffer commandBuffer) => vkCmdEndConditionalRenderingEXT(commandBuffer);
        [DllImport("vulkan-1")] private static extern void vkCmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer);
        public static void CmdEndDebugUtilsLabel(VkCommandBuffer commandBuffer) => vkCmdEndDebugUtilsLabelEXT(commandBuffer);
        [DllImport("vulkan-1")] private static extern void vkCmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index);
        public static void CmdEndQueryIndexed(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index) => vkCmdEndQueryIndexedEXT(commandBuffer, queryPool, query, index);
        [DllImport("vulkan-1")] private static extern void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* counterBuffers, VkDeviceSize* counterBufferOffsets);
        public static void CmdEndTransformFeedback(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* counterBuffers, VkDeviceSize* counterBufferOffsets) => vkCmdEndTransformFeedbackEXT(commandBuffer, firstCounterBuffer, counterBufferCount, counterBuffers, counterBufferOffsets);
        [DllImport("vulkan-1")] private static extern void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabel* labelInfo);
        public static void CmdInsertDebugUtilsLabel(VkCommandBuffer commandBuffer, VkDebugUtilsLabel* labelInfo) => vkCmdInsertDebugUtilsLabelEXT(commandBuffer, labelInfo);
        [DllImport("vulkan-1")] private static extern void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* discardRectangles);
        public static void CmdSetDiscardRectangle(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* discardRectangles) => vkCmdSetDiscardRectangleEXT(commandBuffer, firstDiscardRectangle, discardRectangleCount, discardRectangles);
        [DllImport("vulkan-1")] private static extern void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern);
        public static void CmdSetLineStipple(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern) => vkCmdSetLineStippleEXT(commandBuffer, lineStippleFactor, lineStipplePattern);
        [DllImport("vulkan-1")] private static extern void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfo* sampleLocationsInfo);
        public static void CmdSetSampleLocations(VkCommandBuffer commandBuffer, VkSampleLocationsInfo* sampleLocationsInfo) => vkCmdSetSampleLocationsEXT(commandBuffer, sampleLocationsInfo);
        [DllImport("vulkan-1")] private static extern VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkDebugReportCallback* callback);
        public static void CreateDebugReportCallback(VkInstance instance, VkDebugReportCallbackCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkDebugReportCallback* callback) => vkCreateDebugReportCallbackEXT(instance, createInfo, allocator, callback).AssertSuccess(nameof(vkCreateDebugReportCallbackEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkDebugUtilsMessenger* messenger);
        public static void CreateDebugUtilsMessenger(VkInstance instance, VkDebugUtilsMessengerCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkDebugUtilsMessenger* messenger) => vkCreateDebugUtilsMessengerEXT(instance, createInfo, allocator, messenger).AssertSuccess(nameof(vkCreateDebugUtilsMessengerEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkSurface* surface);
        public static void CreateHeadlessSurface(VkInstance instance, VkHeadlessSurfaceCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkSurface* surface) => vkCreateHeadlessSurfaceEXT(instance, createInfo, allocator, surface).AssertSuccess(nameof(vkCreateHeadlessSurfaceEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkSurface* surface);
        public static void CreateMetalSurface(VkInstance instance, VkMetalSurfaceCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkSurface* surface) => vkCreateMetalSurfaceEXT(instance, createInfo, allocator, surface).AssertSuccess(nameof(vkCreateMetalSurfaceEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkValidationCache* validationCache);
        public static void CreateValidationCache(VkDevice device, VkValidationCacheCreateInfo* createInfo, VkAllocationCallbacks* allocator, VkValidationCache* validationCache) => vkCreateValidationCacheEXT(device, createInfo, allocator, validationCache).AssertSuccess(nameof(vkCreateValidationCacheEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfo* nameInfo);
        public static void DebugMarkerSetObjectName(VkDevice device, VkDebugMarkerObjectNameInfo* nameInfo) => vkDebugMarkerSetObjectNameEXT(device, nameInfo).AssertSuccess(nameof(vkDebugMarkerSetObjectNameEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfo* tagInfo);
        public static void DebugMarkerSetObjectTag(VkDevice device, VkDebugMarkerObjectTagInfo* tagInfo) => vkDebugMarkerSetObjectTagEXT(device, tagInfo).AssertSuccess(nameof(vkDebugMarkerSetObjectTagEXT));
        [DllImport("vulkan-1")] private static extern void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlags flags, VkDebugReportObjectType @objectType, ulong @object, nuint location, int messageCode, string layerPrefix, string message);
        public static void DebugReportMessage(VkInstance instance, VkDebugReportFlags flags, VkDebugReportObjectType @objectType, ulong @object, nuint location, int messageCode, string layerPrefix, string message) => vkDebugReportMessageEXT(instance, flags, @objectType, @object, location, messageCode, layerPrefix, message);
        [DllImport("vulkan-1")] private static extern void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallback callback, VkAllocationCallbacks* allocator);
        public static void DestroyDebugReportCallback(VkInstance instance, VkDebugReportCallback callback, VkAllocationCallbacks* allocator) => vkDestroyDebugReportCallbackEXT(instance, callback, allocator);
        [DllImport("vulkan-1")] private static extern void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessenger messenger, VkAllocationCallbacks* allocator);
        public static void DestroyDebugUtilsMessenger(VkInstance instance, VkDebugUtilsMessenger messenger, VkAllocationCallbacks* allocator) => vkDestroyDebugUtilsMessengerEXT(instance, messenger, allocator);
        [DllImport("vulkan-1")] private static extern void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCache validationCache, VkAllocationCallbacks* allocator);
        public static void DestroyValidationCache(VkDevice device, VkValidationCache validationCache, VkAllocationCallbacks* allocator) => vkDestroyValidationCacheEXT(device, validationCache, allocator);
        [DllImport("vulkan-1")] private static extern VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplay display, VkDisplayPowerInfo* displayPowerInfo);
        public static void DisplayPowerControl(VkDevice device, VkDisplay display, VkDisplayPowerInfo* displayPowerInfo) => vkDisplayPowerControlEXT(device, display, displayPowerInfo).AssertSuccess(nameof(vkDisplayPowerControlEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfo* timestampInfos, ulong* timestamps, ulong* maxDeviation);
        public static void GetCalibratedTimestamps(VkDevice device, uint timestampCount, VkCalibratedTimestampInfo* timestampInfos, ulong* timestamps, ulong* maxDeviation) => vkGetCalibratedTimestampsEXT(device, timestampCount, timestampInfos, timestamps, maxDeviation).AssertSuccess(nameof(vkGetCalibratedTimestampsEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2* surfaceInfo, VkDeviceGroupPresentModeFlags* modes);
        public static VkResult GetDeviceGroupSurfacePresentModes2(VkDevice device, VkPhysicalDeviceSurfaceInfo2* surfaceInfo, VkDeviceGroupPresentModeFlags* modes) => vkGetDeviceGroupSurfacePresentModes2EXT(device, surfaceInfo, modes);
        [DllImport("vulkan-1")] private static extern VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierProperties* properties);
        public static void GetImageDrmFormatModifierProperties(VkDevice device, VkImage image, VkImageDrmFormatModifierProperties* properties) => vkGetImageDrmFormatModifierPropertiesEXT(device, image, properties).AssertSuccess(nameof(vkGetImageDrmFormatModifierPropertiesEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* hostPointer, VkMemoryHostPointerProperties* memoryHostPointerProperties);
        public static void GetMemoryHostPointerProperties(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* hostPointer, VkMemoryHostPointerProperties* memoryHostPointerProperties) => vkGetMemoryHostPointerPropertiesEXT(device, handleType, hostPointer, memoryHostPointerProperties).AssertSuccess(nameof(vkGetMemoryHostPointerPropertiesEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* timeDomainCount, VkTimeDomain* timeDomains);
        public static void GetPhysicalDeviceCalibrateableTimeDomains(VkPhysicalDevice physicalDevice, uint* timeDomainCount, VkTimeDomain* timeDomains) => vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(physicalDevice, timeDomainCount, timeDomains).AssertSuccess(nameof(vkGetPhysicalDeviceCalibrateableTimeDomainsEXT));
        [DllImport("vulkan-1")] private static extern void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, VkMultisampleProperties* multisampleProperties);
        public static void GetPhysicalDeviceMultisampleProperties(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, VkMultisampleProperties* multisampleProperties) => vkGetPhysicalDeviceMultisamplePropertiesEXT(physicalDevice, samples, multisampleProperties);
        [DllImport("vulkan-1")] private static extern VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurface surface, Structs.Extension.VkSurfaceCapabilities2* surfaceCapabilities);
        public static VkResult GetPhysicalDeviceSurfaceCapabilities2(VkPhysicalDevice physicalDevice, VkSurface surface, Structs.Extension.VkSurfaceCapabilities2* surfaceCapabilities) => vkGetPhysicalDeviceSurfaceCapabilities2EXT(physicalDevice, surface, surfaceCapabilities);
        [DllImport("vulkan-1")] private static extern VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2* surfaceInfo, uint* presentModeCount, VkPresentMode* presentModes);
        public static VkResult GetPhysicalDeviceSurfacePresentModes2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2* surfaceInfo, uint* presentModeCount, VkPresentMode* presentModes) => vkGetPhysicalDeviceSurfacePresentModes2EXT(physicalDevice, surfaceInfo, presentModeCount, presentModes);
        [DllImport("vulkan-1")] private static extern VkResult vkGetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint* toolCount, VkPhysicalDeviceToolProperties* toolProperties);
        public static void GetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, uint* toolCount, VkPhysicalDeviceToolProperties* toolProperties) => vkGetPhysicalDeviceToolPropertiesEXT(physicalDevice, toolCount, toolProperties).AssertSuccess(nameof(vkGetPhysicalDeviceToolPropertiesEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchain swapchain, VkSurfaceCounterFlags counter, ulong* counterValue);
        public static void GetSwapchainCounter(VkDevice device, VkSwapchain swapchain, VkSurfaceCounterFlags counter, ulong* counterValue) => vkGetSwapchainCounterEXT(device, swapchain, counter, counterValue).AssertSuccess(nameof(vkGetSwapchainCounterEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCache validationCache, nuint* dataSize, void* data);
        public static void GetValidationCacheData(VkDevice device, VkValidationCache validationCache, nuint* dataSize, void* data) => vkGetValidationCacheDataEXT(device, validationCache, dataSize, data).AssertSuccess(nameof(vkGetValidationCacheDataEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCache dstCache, uint srcCacheCount, VkValidationCache* srcCaches);
        public static void MergeValidationCaches(VkDevice device, VkValidationCache dstCache, uint srcCacheCount, VkValidationCache* srcCaches) => vkMergeValidationCachesEXT(device, dstCache, srcCacheCount, srcCaches).AssertSuccess(nameof(vkMergeValidationCachesEXT));
        [DllImport("vulkan-1")] private static extern void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabel* labelInfo);
        public static void QueueBeginDebugUtilsLabel(VkQueue queue, VkDebugUtilsLabel* labelInfo) => vkQueueBeginDebugUtilsLabelEXT(queue, labelInfo);
        [DllImport("vulkan-1")] private static extern void vkQueueEndDebugUtilsLabelEXT(VkQueue queue);
        public static void QueueEndDebugUtilsLabel(VkQueue queue) => vkQueueEndDebugUtilsLabelEXT(queue);
        [DllImport("vulkan-1")] private static extern void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabel* labelInfo);
        public static void QueueInsertDebugUtilsLabel(VkQueue queue, VkDebugUtilsLabel* labelInfo) => vkQueueInsertDebugUtilsLabelEXT(queue, labelInfo);
        [DllImport("vulkan-1")] private static extern VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfo* deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
        public static void RegisterDeviceEvent(VkDevice device, VkDeviceEventInfo* deviceEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => vkRegisterDeviceEventEXT(device, deviceEventInfo, allocator, fence).AssertSuccess(nameof(vkRegisterDeviceEventEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplay display, VkDisplayEventInfo* displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence);
        public static void RegisterDisplayEvent(VkDevice device, VkDisplay display, VkDisplayEventInfo* displayEventInfo, VkAllocationCallbacks* allocator, VkFence* fence) => vkRegisterDisplayEventEXT(device, display, displayEventInfo, allocator, fence).AssertSuccess(nameof(vkRegisterDisplayEventEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplay display);
        public static void ReleaseDisplay(VkPhysicalDevice physicalDevice, VkDisplay display) => vkReleaseDisplayEXT(physicalDevice, display).AssertSuccess(nameof(vkReleaseDisplayEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchain swapchain);
        public static void ReleaseFullScreenExclusiveMode(VkDevice device, VkSwapchain swapchain) => vkReleaseFullScreenExclusiveModeEXT(device, swapchain).AssertSuccess(nameof(vkReleaseFullScreenExclusiveModeEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfo* nameInfo);
        public static void SetDebugUtilsObjectName(VkDevice device, VkDebugUtilsObjectNameInfo* nameInfo) => vkSetDebugUtilsObjectNameEXT(device, nameInfo).AssertSuccess(nameof(vkSetDebugUtilsObjectNameEXT));
        [DllImport("vulkan-1")] private static extern VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfo* tagInfo);
        public static void SetDebugUtilsObjectTag(VkDevice device, VkDebugUtilsObjectTagInfo* tagInfo) => vkSetDebugUtilsObjectTagEXT(device, tagInfo).AssertSuccess(nameof(vkSetDebugUtilsObjectTagEXT));
        [DllImport("vulkan-1")] private static extern void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchain* swapchains, VkHdrMetadata* metadata);
        public static void SetHdrMetadata(VkDevice device, uint swapchainCount, VkSwapchain* swapchains, VkHdrMetadata* metadata) => vkSetHdrMetadataEXT(device, swapchainCount, swapchains, metadata);
        [DllImport("vulkan-1")] private static extern void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlags messageSeverity, VkDebugUtilsMessageTypeFlags messageTypes, VkDebugUtilsMessengerCallbackData* callbackData);
        public static void SubmitDebugUtilsMessage(VkInstance instance, VkDebugUtilsMessageSeverityFlags messageSeverity, VkDebugUtilsMessageTypeFlags messageTypes, VkDebugUtilsMessengerCallbackData* callbackData) => vkSubmitDebugUtilsMessageEXT(instance, messageSeverity, messageTypes, callbackData);
    }
}