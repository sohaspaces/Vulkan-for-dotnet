using System;
using Vulkan.Enums;
namespace Vulkan
{
    public sealed class VulkanException : Exception
    {
        public VkResult Result { get; }
        public string Function { get; }

        public VulkanException(string function, VkResult result) : base(string.Format(ExceptionMessages.VulkanNotSuccess, function, result))
        {
            Function = function;
            Result = result;
        }
    }
}
