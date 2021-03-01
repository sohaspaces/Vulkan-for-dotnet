using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using Vulkan.Handles;
using Vulkan.Structs;
using Vulkan.Enums;

namespace VulkanManaged
{
    /// <summary>
    /// Runs every computing/graphics operations.
    /// </summary>
    public sealed class CommandQueue
    {

        #region Instance Members

        /// <summary>
        /// The unmanaged handle of the command queue.
        /// </summary>
        public VkQueue Handle { get; init; }

        /// <summary>
        /// The logical device by which the <see cref="CommandQueue"/> instance was created.
        /// </summary>
        public LogicalDevice Device { get; init; }

        #endregion

        #region Constructors

        internal CommandQueue(VkQueue handle, LogicalDevice device)
        {
            Handle = handle;
            Device = device;
        }

        #endregion
    }
}
