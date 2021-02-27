using System;
using Vulkan;
using Vulkan.Structs;
using Vulkan.Structs.Extension;
using Vulkan.Enums;
using Vulkan.Enums.Extension;
using Vulkan.Handles;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VulkanManaged
{
    public delegate void DebugCallback(VkDebugUtilsMessageSeverityFlags severity, VkDebugUtilsMessageTypeFlags type, VkDebugUtilsMessengerCallbackData data);

    /// <summary>
    /// <para>This class connects to the Khronos Vulkan API, by calling <see cref="Vk.CreateInstance(ref VkInstanceCreateInfo, VkAllocationCallbacks[], out VkInstance)"/>.</para>
    /// <para>This class features: </para>
    /// <list type="bullet">
    /// <item>
    /// <term>
    /// Validation
    /// </term>
    /// <description>
    /// It enables all of the validation layers supported in the current environment. The validation messages can be received by <see cref="VulkanApi.DebugCallback"/>
    /// </description>
    /// </item>
    /// <item>
    /// <term>
    /// Physical Devices
    /// </term>
    /// <description>
    /// It provides all of the physical devices presenting in the current environment. The physical devices are in <see cref="VulkanApi.PhysicalDevices"/>
    /// </description>
    /// </item>
    /// </list>
    /// </summary>
    public sealed class VulkanApi : IDisposable
    {

        #region Info

        public sealed record Info
        {
            public (int, int, int) ApiVersion { get; init; }
            public IEnumerable<string> ApiExtensions { get; init; }

            public VkInstanceCreateFlags ApiFlags { get; init; }

            public VkDebugUtilsMessengerCreateFlags DebugFlags { get; init; }
            public VkDebugUtilsMessageTypeFlags DebugMessageTypes { get; init; } = VkDebugUtilsMessageTypeFlags.General;
            public VkDebugUtilsMessageSeverityFlags DebugMessageSeverities { get; init; } = VkDebugUtilsMessageSeverityFlags.Error;
            public VkDebugUtilsMessengerCallbackDataFlags DebugCallbackDataFlags { get; init; }


            public string AppName { get; init; }
            public (int, int, int) AppVersion { get; init; }

            public string EngineName { get; init; }
            public (int, int, int) EngineVersion { get; init; }

            public unsafe IEnumerable<INext<VkApplicationInfo>> AppNexts { get; init; }
            public unsafe IEnumerable<INext<VkInstanceCreateInfo>> ApiNexts { get; init; }
        }

        #endregion
        
        #region Instance Members

        private VkInstance api;

        public event DebugCallback DebugCallback;

        private unsafe VkBool32 InternalDebugCallback(VkDebugUtilsMessageSeverityFlags severity, VkDebugUtilsMessageTypeFlags types, VkDebugUtilsMessengerCallbackData* callbackData, void* userData)
        {
            DebugCallback?.Invoke(severity, types, *callbackData);
            return true;
        }

        private IEnumerable<PhysicalDevice> physicalDevices;

        public IEnumerable<PhysicalDevice> PhysicalDevices
        {
            get
            {
                if(physicalDevices == null)
                {
                    uint count = 0;
                    Vk.EnumeratePhysicalDevices(api, ref count, null);
                    var array = new VkPhysicalDevice[count];
                    Vk.EnumeratePhysicalDevices(api, ref count, array);
                    physicalDevices = from handle in array
                                      select PhysicalDevice.FromHandle(handle);
                }
                return physicalDevices;
            }
        }

        #endregion

        #region Constructors

        public unsafe VulkanApi(Info info)
        {
            var extensionData = info.ApiExtensions.Union(debugExtensions).ToArray();
            var layerData = layers.ToArray();

            var appInfo = new VkApplicationInfo()
            {
                StructureType = VkStructureType.ApplicationInfo,
                ApiVersion = info.ApiVersion.ComposeVersion(),

                ApplicationName = info.AppName.Pin(Encoding.UTF8),
                ApplicationVersion = info.AppVersion.ComposeVersion(),
                
                EngineName = info.EngineName.Pin(Encoding.UTF8),
                EngineVersion = info.EngineVersion.ComposeVersion(),
                
                Next = info.AppNexts.MakeChain()
            };

            var debugInfo = new VkDebugUtilsMessengerCreateInfo()
            {
                StructureType = VkStructureType.DebugUtilsMessengerCreateInfoExt,
                Flags = info.DebugFlags,

                MessageType = info.DebugMessageTypes,
                MessageSeverity = info.DebugMessageSeverities,

                UserCallbackMethod = InternalDebugCallback,
                UserData = null,

                Next = info.ApiNexts.MakeChain()
            };

            var apiInfo = new VkInstanceCreateInfo()
            {
                StructureType = VkStructureType.InstanceCreateInfo,
                EnabledExtensionCount = (uint)extensionData.Length,
                EnabledExtensionNames = extensionData.Pin(Encoding.UTF8),
                EnabledLayerCount = (uint)layerData.Length,
                EnabledLayerNames = layerData.Pin(Encoding.UTF8),
                Flags = info.ApiFlags,
                ApplicationInfo = appInfo.Pin(),
                Next = &debugInfo
            };

            try
            {
                Vk.CreateInstance(ref apiInfo, null, out api);
            }
            catch(VulkanException exception)
            {
                var result = exception.Result;
                if (result == VkResult.ErrorExtensionNotPresent)
                    throw new NotSupportedException(ExceptionMessages.ExtensionNotPresent);
                if(result == VkResult.ErrorLayerNotPresent)
                    throw new NotSupportedException(ExceptionMessages.LayerNotPresent);
                throw exception;
            }
        }

        #endregion

        #region Destructors

        private bool disposedValue;

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                Vk.DestroyInstance(api, Array.Empty<VkAllocationCallbacks>());
                disposedValue = true;
            }
        }

        ~VulkanApi()
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

        #region Static Members

        private static readonly IEnumerable<string> debugExtensions = new List<string>
        {
            "VK_EXT_debug_utils"
        };

        private static IEnumerable<string> extensions;

        public static IEnumerable<string> SupportedExtensions
        {
            get
            {
                if (extensions == null)
                {
                    uint count = 0;
                    Vk.EnumerateInstanceExtensionProperties(null, ref count, null);
                    var extensions = new VkExtensionProperties[count];
                    Vk.EnumerateInstanceExtensionProperties(null, ref count, extensions);
                    VulkanApi.extensions = from property in extensions
                                           select (string)property.ExtensionName;
                }
                return extensions;
            }
        }

        public static bool IsSupportedExtension(string name)
            => SupportedExtensions.Contains(name);

        public static bool IsSupportedExtensions(IEnumerable<string> names)
            => names.All((name) => SupportedExtensions.Contains(name));

        private static IEnumerable<string> layers;

        public static IEnumerable<string> SupportedLayers
        {
            get
            {
                if (layers == null)
                {
                    uint count = 0;
                    Vk.EnumerateInstanceLayerProperties(ref count, null);
                    var extensions = new VkLayerProperties[count];
                    Vk.EnumerateInstanceLayerProperties(ref count, extensions);
                    VulkanApi.layers = from property in extensions
                                       select (string)property.LayerName;
                }
                return layers;
            }
        }


        #endregion

    }
}
