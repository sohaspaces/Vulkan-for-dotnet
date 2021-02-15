using System;
using Vulkan.Enums;
namespace Vulkan
{
    public sealed class VulkanException : Exception
    {
        public VulkanException(string function, VkResult result) : base(string.Format(ExceptionMessages.VulkanNotSuccess, function, result))
        {
        }
    }
}
