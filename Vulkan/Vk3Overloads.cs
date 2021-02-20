using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Intel;
using Vulkan.Handles;
using Vulkan.Handles.Intel;
using Vulkan.Structs.Intel;
namespace Vulkan
{
    public static unsafe partial class VkIntel
    {
        [DllImport("vulkan-1")] private static extern VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfo acquireInfo, ref VkPerformanceConfiguration configuration);
        public static void AcquirePerformanceConfiguration(VkDevice device, ref VkPerformanceConfigurationAcquireInfo acquireInfo, ref VkPerformanceConfiguration configuration) => vkAcquirePerformanceConfigurationINTEL(device, ref acquireInfo, ref configuration).AssertSuccess(nameof(vkAcquirePerformanceConfigurationINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfo[] acquireInfo, ref VkPerformanceConfiguration configuration);
        public static void AcquirePerformanceConfiguration(VkDevice device, VkPerformanceConfigurationAcquireInfo[] acquireInfo, ref VkPerformanceConfiguration configuration) => vkAcquirePerformanceConfigurationINTEL(device, acquireInfo, ref configuration).AssertSuccess(nameof(vkAcquirePerformanceConfigurationINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfo acquireInfo, VkPerformanceConfiguration[] configuration);
        public static void AcquirePerformanceConfiguration(VkDevice device, ref VkPerformanceConfigurationAcquireInfo acquireInfo, VkPerformanceConfiguration[] configuration) => vkAcquirePerformanceConfigurationINTEL(device, ref acquireInfo, configuration).AssertSuccess(nameof(vkAcquirePerformanceConfigurationINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfo[] acquireInfo, VkPerformanceConfiguration[] configuration);
        public static void AcquirePerformanceConfiguration(VkDevice device, VkPerformanceConfigurationAcquireInfo[] acquireInfo, VkPerformanceConfiguration[] configuration) => vkAcquirePerformanceConfigurationINTEL(device, acquireInfo, configuration).AssertSuccess(nameof(vkAcquirePerformanceConfigurationINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceMarkerInfo markerInfo);
        public static void CmdSetPerformanceMarker(VkCommandBuffer commandBuffer, ref VkPerformanceMarkerInfo markerInfo) => vkCmdSetPerformanceMarkerINTEL(commandBuffer, ref markerInfo).AssertSuccess(nameof(vkCmdSetPerformanceMarkerINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfo[] markerInfo);
        public static void CmdSetPerformanceMarker(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfo[] markerInfo) => vkCmdSetPerformanceMarkerINTEL(commandBuffer, markerInfo).AssertSuccess(nameof(vkCmdSetPerformanceMarkerINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceOverrideInfo overrideInfo);
        public static void CmdSetPerformanceOverride(VkCommandBuffer commandBuffer, ref VkPerformanceOverrideInfo overrideInfo) => vkCmdSetPerformanceOverrideINTEL(commandBuffer, ref overrideInfo).AssertSuccess(nameof(vkCmdSetPerformanceOverrideINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfo[] overrideInfo);
        public static void CmdSetPerformanceOverride(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfo[] overrideInfo) => vkCmdSetPerformanceOverrideINTEL(commandBuffer, overrideInfo).AssertSuccess(nameof(vkCmdSetPerformanceOverrideINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceStreamMarkerInfo markerInfo);
        public static void CmdSetPerformanceStreamMarker(VkCommandBuffer commandBuffer, ref VkPerformanceStreamMarkerInfo markerInfo) => vkCmdSetPerformanceStreamMarkerINTEL(commandBuffer, ref markerInfo).AssertSuccess(nameof(vkCmdSetPerformanceStreamMarkerINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfo[] markerInfo);
        public static void CmdSetPerformanceStreamMarker(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfo[] markerInfo) => vkCmdSetPerformanceStreamMarkerINTEL(commandBuffer, markerInfo).AssertSuccess(nameof(vkCmdSetPerformanceStreamMarkerINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterType parameter, ref VkPerformanceValue value);
        public static void GetPerformanceParameter(VkDevice device, VkPerformanceParameterType parameter, ref VkPerformanceValue value) => vkGetPerformanceParameterINTEL(device, parameter, ref value).AssertSuccess(nameof(vkGetPerformanceParameterINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterType parameter, VkPerformanceValue[] value);
        public static void GetPerformanceParameter(VkDevice device, VkPerformanceParameterType parameter, VkPerformanceValue[] value) => vkGetPerformanceParameterINTEL(device, parameter, value).AssertSuccess(nameof(vkGetPerformanceParameterINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkInitializePerformanceApiINTEL(VkDevice device, ref VkInitializePerformanceApiInfo initializeInfo);
        public static void InitializePerformanceApi(VkDevice device, ref VkInitializePerformanceApiInfo initializeInfo) => vkInitializePerformanceApiINTEL(device, ref initializeInfo).AssertSuccess(nameof(vkInitializePerformanceApiINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkInitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfo[] initializeInfo);
        public static void InitializePerformanceApi(VkDevice device, VkInitializePerformanceApiInfo[] initializeInfo) => vkInitializePerformanceApiINTEL(device, initializeInfo).AssertSuccess(nameof(vkInitializePerformanceApiINTEL));
    }
}