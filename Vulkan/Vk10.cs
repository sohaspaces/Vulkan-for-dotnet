using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Amd;
using Vulkan.Handles;
using Vulkan.Handles.Khronos;
namespace Vulkan
{
    public static unsafe class VkAmd
    {
        [DllImport("vulkan-1")] private static extern void vkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint marker);
        public static void CmdWriteBufferMarker(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, VkDeviceSize dstOffset, uint marker) => vkCmdWriteBufferMarkerAMD(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
        [DllImport("vulkan-1")] private static extern VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoType infoType, nuint* infoSize, void* info);
        public static void GetShaderInfo(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoType infoType, nuint* infoSize, void* info) => vkGetShaderInfoAMD(device, pipeline, shaderStage, infoType, infoSize, info).AssertSuccess(nameof(vkGetShaderInfoAMD));
        [DllImport("vulkan-1")] private static extern void vkSetLocalDimmingAMD(VkDevice device, VkSwapchain swapChain, VkBool32 localDimmingEnable);
        public static void SetLocalDimming(VkDevice device, VkSwapchain swapChain, VkBool32 localDimmingEnable) => vkSetLocalDimmingAMD(device, swapChain, localDimmingEnable);
    }
}