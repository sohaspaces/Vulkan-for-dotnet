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
        [DllImport("vulkan-1")] private static extern VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, [In, Out]VkPerformanceConfigurationAcquireInfo[] acquireInfo, ref VkPerformanceConfiguration configuration);
        public static void AcquirePerformanceConfiguration(VkDevice device, [In, Out]VkPerformanceConfigurationAcquireInfo[] acquireInfo, ref VkPerformanceConfiguration configuration) => vkAcquirePerformanceConfigurationINTEL(device, acquireInfo, ref configuration).AssertSuccess(nameof(vkAcquirePerformanceConfigurationINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, ref VkPerformanceConfigurationAcquireInfo acquireInfo, [In, Out]VkPerformanceConfiguration[] configuration);
        public static void AcquirePerformanceConfiguration(VkDevice device, ref VkPerformanceConfigurationAcquireInfo acquireInfo, [In, Out]VkPerformanceConfiguration[] configuration) => vkAcquirePerformanceConfigurationINTEL(device, ref acquireInfo, configuration).AssertSuccess(nameof(vkAcquirePerformanceConfigurationINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, [In, Out]VkPerformanceConfigurationAcquireInfo[] acquireInfo, [In, Out]VkPerformanceConfiguration[] configuration);
        public static void AcquirePerformanceConfiguration(VkDevice device, [In, Out]VkPerformanceConfigurationAcquireInfo[] acquireInfo, [In, Out]VkPerformanceConfiguration[] configuration) => vkAcquirePerformanceConfigurationINTEL(device, acquireInfo, configuration).AssertSuccess(nameof(vkAcquirePerformanceConfigurationINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceMarkerInfo markerInfo);
        public static void CmdSetPerformanceMarker(VkCommandBuffer commandBuffer, ref VkPerformanceMarkerInfo markerInfo) => vkCmdSetPerformanceMarkerINTEL(commandBuffer, ref markerInfo).AssertSuccess(nameof(vkCmdSetPerformanceMarkerINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, [In, Out]VkPerformanceMarkerInfo[] markerInfo);
        public static void CmdSetPerformanceMarker(VkCommandBuffer commandBuffer, [In, Out]VkPerformanceMarkerInfo[] markerInfo) => vkCmdSetPerformanceMarkerINTEL(commandBuffer, markerInfo).AssertSuccess(nameof(vkCmdSetPerformanceMarkerINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceOverrideInfo overrideInfo);
        public static void CmdSetPerformanceOverride(VkCommandBuffer commandBuffer, ref VkPerformanceOverrideInfo overrideInfo) => vkCmdSetPerformanceOverrideINTEL(commandBuffer, ref overrideInfo).AssertSuccess(nameof(vkCmdSetPerformanceOverrideINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, [In, Out]VkPerformanceOverrideInfo[] overrideInfo);
        public static void CmdSetPerformanceOverride(VkCommandBuffer commandBuffer, [In, Out]VkPerformanceOverrideInfo[] overrideInfo) => vkCmdSetPerformanceOverrideINTEL(commandBuffer, overrideInfo).AssertSuccess(nameof(vkCmdSetPerformanceOverrideINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, ref VkPerformanceStreamMarkerInfo markerInfo);
        public static void CmdSetPerformanceStreamMarker(VkCommandBuffer commandBuffer, ref VkPerformanceStreamMarkerInfo markerInfo) => vkCmdSetPerformanceStreamMarkerINTEL(commandBuffer, ref markerInfo).AssertSuccess(nameof(vkCmdSetPerformanceStreamMarkerINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, [In, Out]VkPerformanceStreamMarkerInfo[] markerInfo);
        public static void CmdSetPerformanceStreamMarker(VkCommandBuffer commandBuffer, [In, Out]VkPerformanceStreamMarkerInfo[] markerInfo) => vkCmdSetPerformanceStreamMarkerINTEL(commandBuffer, markerInfo).AssertSuccess(nameof(vkCmdSetPerformanceStreamMarkerINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterType parameter, out VkPerformanceValue value);
        public static void GetPerformanceParameter(VkDevice device, VkPerformanceParameterType parameter, out VkPerformanceValue value) => vkGetPerformanceParameterINTEL(device, parameter, out value).AssertSuccess(nameof(vkGetPerformanceParameterINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterType parameter, [In, Out]VkPerformanceValue[] value);
        public static void GetPerformanceParameter(VkDevice device, VkPerformanceParameterType parameter, [In, Out]VkPerformanceValue[] value) => vkGetPerformanceParameterINTEL(device, parameter, value).AssertSuccess(nameof(vkGetPerformanceParameterINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkInitializePerformanceApiINTEL(VkDevice device, ref VkInitializePerformanceApiInfo initializeInfo);
        public static void InitializePerformanceApi(VkDevice device, ref VkInitializePerformanceApiInfo initializeInfo) => vkInitializePerformanceApiINTEL(device, ref initializeInfo).AssertSuccess(nameof(vkInitializePerformanceApiINTEL));
        [DllImport("vulkan-1")] private static extern VkResult vkInitializePerformanceApiINTEL(VkDevice device, [In, Out]VkInitializePerformanceApiInfo[] initializeInfo);
        public static void InitializePerformanceApi(VkDevice device, [In, Out]VkInitializePerformanceApiInfo[] initializeInfo) => vkInitializePerformanceApiINTEL(device, initializeInfo).AssertSuccess(nameof(vkInitializePerformanceApiINTEL));
    }
}