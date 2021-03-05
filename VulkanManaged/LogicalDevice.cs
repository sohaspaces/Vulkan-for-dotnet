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
    /// <para>Represents a logical device usable by Khronos Vulkan API.</para>
    /// <para>It makes possible to actually use the computing/graphics features in the <see cref="PhysicalDevice"/>.</para>
    /// </summary>
    public sealed class LogicalDevice : IDisposable
    {

        #region Infos

        /// <summary>
        /// Customizable information for <see cref="VkQueueFamilyProperties"/>.
        /// </summary>
        public sealed record QueueInfo
        {
            /// <summary>
            /// It is the equivalent of the <see cref="VkDeviceQueueCreateInfo.QueuePriorities"/> (native name: <c>queuePriorities</c>).
            /// Please change this into a friendly explanation.
            /// </summary>
            public float[] Priorities { get; init; }

            /// <summary>
            /// The <c>pNext</c> chain components for <see cref="VkDeviceQueueCreateInfo"/>.
            /// </summary>
            /// <seealso cref="INext{TAbout}"/>
            public IEnumerable<INext<VkDeviceQueueCreateInfo>> Nexts { get; init; } = Enumerable.Empty<INext<VkDeviceQueueCreateInfo>>();

            /// <summary>
            /// The flags for <see cref="VkDeviceQueueCreateInfo"/>.
            /// </summary>
            public VkDeviceQueueCreateFlags Flags { get; init; }

            public bool IsValidWith(VkQueueFamilyProperties family)
                => family.QueueCount == Priorities.Length;
        }

        /// <summary>
        /// Information for creating a <see cref="LogicalDevice"/> instance.
        /// </summary>
        public sealed record Info
        {
            /// <summary>
            /// The physical device on which the logical device is supposed to be based
            /// </summary>
            public PhysicalDevice PhysicalDevice { get; init; }

            /// <summary>
            /// <para>
            /// The enabled device extensions.
            /// The default value is an empty enumeration.
            /// <para>
            /// Every components must be the name of an extension about which <see cref="PhysicalDevice.IsSupportedExtension(string)"/> returns true.
            /// </para>
            /// </para>
            /// </summary>
            public IEnumerable<string> DeviceExtensions { get; init; } = Enumerable.Empty<string>();

            /// <summary>
            /// <para>
            /// The enabled device validation layers.
            /// The default value is an empty enumeration.
            /// <para>
            /// Every components must be the name of a validation layer about which <see cref="PhysicalDevice.IsSupportedLayer(string)"/> returns true.
            /// </para>
            /// </para>
            /// </summary>
            public IEnumerable<string> DeviceLayers { get; init; } = Enumerable.Empty<string>();

            /// <summary>
            /// The <c>pNext</c> chain components for <see cref="VkDeviceCreateInfo"/>.
            /// </summary>
            /// <seealso cref="INext{TAbout}"/>
            public IEnumerable<INext<VkDeviceCreateInfo>> Nexts { get; init; } = Enumerable.Empty<INext<VkDeviceCreateInfo>>();

            /// <summary>
            /// <para>
            /// Maps from a <see cref="VkQueueFamilyProperties"/> instance to a new <see cref="QueueInfo"/> instance.
            /// It has to return a valid <see cref="QueueInfo"/> about which <see cref="QueueInfo.IsValidWith(VkQueueFamilyProperties)"/> returns true.
            /// <para>
            /// The default function returns a valid minimal info.
            /// </para>
            /// </para>
            /// </summary>
            public Func<VkQueueFamilyProperties, QueueInfo> QueueInfoMapper { get; init; } =
                (x) => new QueueInfo() { Priorities = new float[x.QueueCount] };

            /// <summary>
            /// The flags for <see cref="VkDeviceCreateInfo"/>.
            /// </summary>
            public VkDeviceCreateFlags Flags { get; init; }
        }

        #endregion

        #region Instance Members

        public VkDevice DeviceHandle { get; private init; }

        public PhysicalDevice PhysicalDevice { get; private init; }

        private Dictionary<uint, VkQueueFamilyProperties> familyProperties;
        private IEnumerable<uint> familyIndices;
        private uint familyCount;

        private Dictionary<(uint, uint), CommandQueue> queues;

        /// <summary>
        /// Each index of all the queue families in the device.
        /// </summary>
        public IEnumerable<uint> QueueFamilyIndices
            => familyIndices;

        /// <summary>
        /// Checks whether the queue family index is valid in the device.
        /// </summary>
        /// <param name="index">The queue family index</param>
        /// <returns><c>true</c> if and only if <paramref name="index"/> is valid.</returns>
        public bool IsValidQueueFamilyIndex(uint index)
            => index >= 0
            && index < familyCount;

        /// <summary>
        /// Gets the properties of the queue family.
        /// </summary>
        /// <param name="index">The index of the queue family, which must be about which <see cref="IsValidQueueFamilyIndex(uint)"/> returns true.</param>
        /// <returns>The properties.</returns>
        public VkQueueFamilyProperties GetQueueFamilyProperties(uint index)
            => familyProperties.TryGetValue(index, out var property)
            ? property
            : throw new ArgumentException(ExceptionMessages.InvalidQueueFamilyIndex, nameof(index));

        /// <summary>
        /// Gets the flags of the queue family.
        /// </summary>
        /// <param name="index">The index of the queue family, which must be about which <see cref="IsValidQueueFamilyIndex(uint)"/> returns true.</param>
        /// <returns>The flags.</returns>
        public VkQueueFlags GetQueueFlags(uint index)
            => GetQueueFamilyProperties(index).QueueFlags;

        /// <summary>
        /// Gets the queue count of the queue family.
        /// </summary>
        /// <param name="index">The index of the queue family, which must be about which <see cref="IsValidQueueFamilyIndex(uint)"/> returns true.</param>
        /// <returns>The count.</returns>
        public uint GetQueueCount(uint index)
            => GetQueueFamilyProperties(index).QueueCount;

        /// <summary>
        /// Gets each index of all of the queues existing in a queue family.
        /// </summary>
        /// <param name="familyIndex">The index of the queue family, which must be about which <see cref="IsValidQueueFamilyIndex(uint)"/> returns true.</param>
        /// <returns>The queue indices.</returns>
        public IEnumerable<uint> GetQueueIndices(uint familyIndex)
            => IsValidQueueFamilyIndex(familyIndex)
            ? from index in Enumerable.Range(0, (int)familyIndex)
              select (uint)index
            : throw new ArgumentException(ExceptionMessages.InvalidQueueFamilyIndex, nameof(familyIndex));

        /// <summary>
        /// Checks if both the queue family and queue index are valid.
        /// </summary>
        /// <param name="familyIndex">The queue family index.</param>
        /// <param name="queueIndex">The queue index.</param>
        /// <returns><c>true</c> if and only if both of them are valid.</returns>
        public bool IsValidQueueIndex(uint familyIndex, uint queueIndex)
            => familyProperties.TryGetValue(familyIndex, out var property)
            && queueIndex >= 0
            && queueIndex < property.QueueCount;

        /// <summary>
        /// Gets the corresponding <see cref="CommandQueue"/> instance,
        /// where <paramref name="familyIndex"/> and <paramref name="queueIndex"/> is about what <see cref="IsValidQueueIndex(uint, uint)"/> returns true.
        /// </summary>
        /// <param name="familyIndex">The queue family index</param>
        /// <param name="queueIndex">The queue index.</param>
        /// <returns>The command queue instance</returns>
        public CommandQueue GetQueue(uint familyIndex, uint queueIndex)
        {
            if (!IsValidQueueIndex(familyIndex, queueIndex))
                throw new ArgumentException(ExceptionMessages.InvalidQueueIndex);
            var key = (familyIndex, queueIndex);
            if (!queues.ContainsKey(key))
            {
                Vk.GetDeviceQueue(DeviceHandle, familyIndex, queueIndex, out var handle);
                queues.Add(key, new CommandQueue(handle, this));
            }
            return queues[key];
        }
        


        #endregion

        #region Constructors

        public unsafe LogicalDevice(Info info)
        {
            if (!info.PhysicalDevice.IsSupportedExtensions(info.DeviceExtensions))
                throw new NotSupportedException(ExceptionMessages.ExtensionNotPresent);

            familyProperties = new Dictionary<uint, VkQueueFamilyProperties>();
            queues = new Dictionary<(uint, uint), CommandQueue>();

            var extensionData = info.DeviceExtensions.ToArray();
            var features = info.PhysicalDevice.Features;
            var layerData = info.PhysicalDevice.SupportedLayers.ToArray();

            var familyData = info.PhysicalDevice.QueueFamilyProperties;

            var queueCount = (uint)familyData.Length;
            var queueData = new VkDeviceQueueCreateInfo[queueCount];

            familyIndices = from index in Enumerable.Range(0, familyData.Length)
                            select (uint)index;

            for (uint i = 0; i < queueCount; i++)
            {
                var family = familyData[i];
                var queueInfo = info.QueueInfoMapper(family);

                if (!queueInfo.IsValidWith(family))
                    throw new InvalidOperationException(ExceptionMessages.InvalidQueueInfo);

                queueData[i] = new VkDeviceQueueCreateInfo()
                {
                    StructureType = VkStructureType.DeviceQueueCreateInfo,

                    QueueCount = family.QueueCount,
                    QueueFamilyIndex = i,
                    QueuePriorities = queueInfo.Priorities.Pin(),
                    
                    Flags = queueInfo.Flags,
                    
                    Next = queueInfo.Nexts.MakeChain()
                };

                familyProperties.Add(i, family);
            }

            var createInfo = new VkDeviceCreateInfo
            {
                StructureType = VkStructureType.DeviceCreateInfo,
                
                Flags = info.Flags,
                
                EnabledExtensionCount = (uint)extensionData.Length,
                EnabledExtensionNames = extensionData.Pin(Encoding.UTF8),
                
                EnabledFeatures = &features,
                
                EnabledLayerCount = (uint)layerData.Length,
                EnabledLayerNames = layerData.Pin(Encoding.UTF8),
                
                QueueCreateInfoCount = (uint)queueData.Length,
                QueueCreateInfos = queueData.Pin(),
                
                Next = info.Nexts.MakeChain()
            };

            familyCount = queueCount;

            Vk.CreateDevice(info.PhysicalDevice.DeviceHandle, ref createInfo, null, out var handle);

            info.PhysicalDevice.Api.AddPreviousDisposable(this);

            DeviceHandle = handle;

            PhysicalDevice = info.PhysicalDevice;
        }

        #endregion

        #region Deconstructors

        private bool disposedValue;

        private List<IDisposable> disposables = new List<IDisposable>();

        public void AddPreviousDisposable(IDisposable x)
            => disposables.Add(x);

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if(disposing)
                {
                    foreach(var disposal in disposables)
                        disposal.Dispose();
                }
                Vk.DestroyDevice(DeviceHandle, (VkAllocationCallbacks[])null);
                disposedValue = true;
            }
        }

        ~LogicalDevice()
        {
           // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion

    }
}
