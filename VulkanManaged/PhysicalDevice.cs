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
    /// Represents a physical device.
    /// </summary>
    public sealed class PhysicalDevice
    {

        #region Instance Members

        /// <summary>
        /// The unmanaged handle of the physical device.
        /// </summary>
        public VkPhysicalDevice Handle { get; init; }

        /// <summary>
        /// The api instance by which the <see cref="PhysicalDevice"/> instance was created.
        /// </summary>
        public VulkanApi Api { get; init; }

        #region Property Related

        private VkPhysicalDeviceProperties? properties;
        
        /// <summary>
        /// The properties of the physical device
        /// </summary>
        public VkPhysicalDeviceProperties Properties
        {
            get
            {
                if(properties == null)
                {
                    Vk.GetPhysicalDeviceProperties(Handle, out var data);
                    properties = data;
                }
                return (VkPhysicalDeviceProperties)properties;
            }
        }

        /// <summary>
        /// The type of the physical device.
        /// </summary>
        public VkPhysicalDeviceType DeviceType
            => Properties.DeviceType;

        /// <summary>
        /// The version of the driver about the physical device in the current environment.
        /// </summary>
        public (int, int, int) DriverVersion
            => Properties.DriverVersion.DecomposeVersion();

        /// <summary>
        /// It is the equivalent of the <see cref="VkPhysicalDeviceProperties.ApiVersion"/> (native name: <c>apiVersion</c>).
        /// Please change this into a friendly explanation.
        /// </summary>
        public (int, int, int) ApiVersion
            => Properties.ApiVersion.DecomposeVersion();

        /// <summary>
        /// The id of the vendor.
        /// </summary>
        public uint VendorId
            => Properties.VendorId;

        /// <summary>
        /// The id of the physical device.
        /// </summary>
        public uint DeviceId
            => Properties.DeviceId;

        /// <summary>
        /// The inherent limits of the physical device.
        /// </summary>
        public VkPhysicalDeviceLimits Limits
            => Properties.Limits;

        /// <summary>
        /// It is the equivalent of the <see cref="VkPhysicalDeviceProperties.SparseProperties"/> (native name: <c>sparseProperties</c>).
        /// Please change this into a friendly explanation.
        /// </summary>
        public VkPhysicalDeviceSparseProperties SparseProperties
            => Properties.SparseProperties;

        /// <summary>
        /// It is the equivalent of the <see cref="VkPhysicalDeviceProperties.PipelineCacheUuid"/> (native name: <c>pipelineCacheUUID</c>).
        /// Please change this into a friendly explanation.
        /// </summary>
        public UnmanagedArray16<uint> PipelineCacheUuid
            => Properties.PipelineCacheUuid;

        private string deviceName;

        /// <summary>
        /// The name of the device.
        /// </summary>
        public string DeviceName
            => deviceName ?? (deviceName = Properties.DeviceName);

        #endregion

        #region Feature Related

        private VkPhysicalDeviceFeatures? features;

        /// <summary>
        /// The inherent features of the physical device.
        /// </summary>
        public VkPhysicalDeviceFeatures Features
        {
            get
            {
                if (features == null)
                {
                    Vk.GetPhysicalDeviceFeatures(Handle, out var data);
                    features = data;
                }
                return (VkPhysicalDeviceFeatures)features;
            }
        }

        #endregion

        #region Queue Related

        private VkQueueFamilyProperties[] queueFamilyProperties;

        /// <summary>
        /// The properties about all of the queue families in this device.
        /// The reason for they being in array is the indices of the properties must be preserved.
        /// </summary>
        public VkQueueFamilyProperties[] QueueFamilyProperties
        {
            get
            {
                if(queueFamilyProperties == null)
                {
                    uint count = 0;
                    Vk.GetPhysicalDeviceQueueFamilyProperties(Handle, ref count, null);
                    var array = new VkQueueFamilyProperties[count];
                    Vk.GetPhysicalDeviceQueueFamilyProperties(Handle, ref count, array);
                    queueFamilyProperties = array;
                }
                return queueFamilyProperties;
            }
        }

        #endregion

        #region Extension Related

        private IEnumerable<string> extensions;

        /// <summary>
        /// All of the supported device extensions in the current environment.
        /// </summary>
        public IEnumerable<string> SupportedExtensions
        {
            get
            {
                if (extensions == null)
                {
                    uint count = 0;
                    Vk.EnumerateDeviceExtensionProperties(Handle, null, ref count, null);
                    var extensions = new VkExtensionProperties[count];
                    Vk.EnumerateDeviceExtensionProperties(Handle, null, ref count, extensions);
                    this.extensions = from property in extensions
                                           select (string)property.ExtensionName;
                }
                return extensions;
            }
        }

        /// <summary>
        /// Checks if an extension is supported in the current environment.
        /// </summary>
        /// <param name="name">The name of the extension</param>
        /// <returns><c>true</c> if and only if the extension is supported</returns>
        public bool IsSupportedExtension(string name)
            => SupportedExtensions.Contains(name);

        /// <summary>
        /// Checks if extensions are supported in the current environment.
        /// </summary>
        /// <param name="names">The names of the extensions.</param>
        /// <returns><c>true</c> if and only if all of the extensions are supported.</returns>
        public bool IsSupportedExtensions(IEnumerable<string> names)
            => names.All((name) => SupportedExtensions.Contains(name));


        private IEnumerable<string> layers;

        /// <summary>
        /// All of the supported Vulkan device validation layers in the current environment.
        /// </summary>
        public IEnumerable<string> SupportedLayers
        {
            get
            {
                if (layers == null)
                {
                    uint count = 0;
                    Vk.EnumerateDeviceLayerProperties(Handle, ref count, null);
                    var extensions = new VkLayerProperties[count];
                    Vk.EnumerateDeviceLayerProperties(Handle, ref count, extensions);
                    this.layers = from property in extensions
                                       select (string)property.LayerName;
                }
                return layers;
            }
        }

        #endregion

        #endregion

        #region Constructors

        internal PhysicalDevice(VkPhysicalDevice handle, VulkanApi api)
        {
            Handle = handle;
            Api = api;
        }

        #endregion

    }
}
