using System.Runtime.InteropServices;
using Vulkan.Enums;
using Vulkan.Enums.Amd;
using Vulkan.Handles;
namespace Vulkan
{
    public static unsafe partial class VkAmd
    {
        [DllImport("vulkan-1")] private static extern VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoType infoType, out nuint infoSize, void* info);
        public static void GetShaderInfo(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoType infoType, out nuint infoSize, void* info) => vkGetShaderInfoAMD(device, pipeline, shaderStage, infoType, out infoSize, info).AssertSuccess(nameof(vkGetShaderInfoAMD));
        [DllImport("vulkan-1")] private static extern VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoType infoType, [In, Out]nuint[] infoSize, void* info);
        public static void GetShaderInfo(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoType infoType, [In, Out]nuint[] infoSize, void* info) => vkGetShaderInfoAMD(device, pipeline, shaderStage, infoType, infoSize, info).AssertSuccess(nameof(vkGetShaderInfoAMD));
    }
}