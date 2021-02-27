using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vulkan;
using Vulkan.Handles;
using Vulkan.Structs;
using Vulkan.Enums;

namespace Vulkan
{
    public sealed class PhysicalDevice
    {

        #region Instance Members

        public VkPhysicalDevice Handle { get; init; }

        #region Property-Related

        private VkPhysicalDeviceProperties2 properties;
        
        public VkPhysicalDeviceProperties Properties
        {
            get
            {
                if(properties.StructureType != VkStructureType.PhysicalDeviceProperties2)
                    Vk.GetPhysicalDeviceProperties2(Handle, out properties);
                return properties.Properties;
            }
        }

        public VkPhysicalDeviceType DeviceType
            => Properties.DeviceType;

        public (int, int, int) DriverVersion
            => Properties.DriverVersion.DecomposeVersion();

        public (int, int, int) ApiVersion
            => Properties.ApiVersion.DecomposeVersion();

        public uint VendorId
            => Properties.VendorId;

        public uint DeviceId
            => Properties.DeviceId;

        public VkPhysicalDeviceLimits Limits
            => Properties.Limits;

        public VkPhysicalDeviceSparseProperties SparseProperties
            => Properties.SparseProperties;

        public UnmanagedArray16<uint> PipelineCacheUuid
            => Properties.PipelineCacheUuid;

        private string deviceName;

        public string DeviceName
            => deviceName ?? (deviceName = Properties.DeviceName);

        #endregion

        #region Feature-related

        private VkPhysicalDeviceFeatures2 features;

        public VkPhysicalDeviceFeatures Features
        {
            get
            {
                if (features.StructureType != VkStructureType.PhysicalDeviceFeatures2)
                    Vk.GetPhysicalDeviceFeatures2(Handle, out features);
                return features.Features;
            }
        }

        #endregion

        #endregion

        #region Constructors

        public static PhysicalDevice FromHandle(VkPhysicalDevice handle)
            => new PhysicalDevice()
            {
                Handle = handle
            };

        #endregion

    }
}
