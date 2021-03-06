﻿using System;
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
        public VkQueue Handle { get; private init; }

        /// <summary>
        /// The logical device by which the <see cref="CommandQueue"/> instance was created.
        /// </summary>
        public LogicalDevice Device { get; private init; }

        public uint FamilyIndex { get; init; }
        public uint QueueIndex { get; init; }

        #endregion

        #region Constructors

        internal CommandQueue(VkQueue handle, LogicalDevice device, uint family, uint queue)
        {
            Handle = handle;
            Device = device;
            FamilyIndex = family;
            QueueIndex = queue;
        }

        #endregion
    
    }
}
