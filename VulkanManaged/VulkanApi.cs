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
    /// It can enable all of the validation layers supported in the current environment. The validation messages can be received by <see cref="VulkanApi.DebugCallback"/>
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

        #region Infos

        /// <summary>
        /// Information to create a <see cref="VulkanApi"/> instance.
        /// </summary>
        public sealed record Info
        {
            /// <summary>
            /// <para>
            /// Version of the Khronos Vulkan API.
            /// <para>
            /// The default value is (1, 0, 0).
            /// </para>
            /// </para>
            /// </summary>
            public (int, int, int) ApiVersion { get; init; } = (1, 0, 0);

            /// <summary>
            /// <para>
            /// The enabled API (instance) extensions.
            /// The default value is an empty enumeration.
            /// <para>
            /// Every components must be the name of an extension about which <see cref="IsSupportedExtension(string)"/> returns true.
            /// </para>
            /// </para>
            /// </summary>
            public IEnumerable<string> ApiExtensions { get; init; } = Enumerable.Empty<string>();

            /// <summary>
            /// <para>
            /// The enabled API (instance) validation layers.
            /// The default value is an empty enumeration.
            /// <para>
            /// Every components must be the name of a validation layer about which <see cref="IsSupportedLayer(string)"/> returns true.
            /// </para>
            /// </para>
            /// </summary>
            public IEnumerable<string> ApiLayers { get; init; } = Enumerable.Empty<string>();

            /// <summary>
            /// The flags for <see cref="VkInstanceCreateInfo"/>
            /// </summary>
            public VkInstanceCreateFlags ApiFlags { get; init; }

            /// <summary>
            /// The flags for <see cref="VkDebugUtilsMessengerCreateInfo"/>
            /// </summary>
            public VkDebugUtilsMessengerCreateFlags DebugFlags { get; init; }

            /// <summary>
            /// <para>
            /// The message types about which it is supposed to invoke <see cref="DebugCallback"/>.
            /// <para>
            /// The default value is <see cref="VkDebugUtilsMessageTypeFlags.General"/>.
            /// </para>
            /// </para>
            /// </summary>
            public VkDebugUtilsMessageTypeFlags DebugMessageTypes { get; init; } = VkDebugUtilsMessageTypeFlags.General;

            /// <summary>
            /// <para>
            /// The message severities about which it is supposed to invoke <see cref="DebugCallback"/>.
            /// <para>
            /// The default value is <see cref="VkDebugUtilsMessageSeverityFlags.Error"/>.
            /// </para>
            /// </para>
            /// </summary>
            public VkDebugUtilsMessageSeverityFlags DebugMessageSeverities { get; init; } = VkDebugUtilsMessageSeverityFlags.Error;

            /// <summary>
            /// <para>
            /// Reserved for future use.
            /// </para>
            /// </summary>
            public VkDebugUtilsMessengerCallbackDataFlags DebugCallbackDataFlags { get; init; }

            /// <summary>
            /// <para>
            /// The name of the app.
            /// </para>
            /// </summary>
            public string AppName { get; init; }

            /// <summary>
            /// <para>
            /// The version of the app.
            /// </para>
            /// </summary>
            public (int, int, int) AppVersion { get; init; }

            /// <summary>
            /// <para>
            /// The name of the engine.
            /// </para>
            /// </summary>
            public string EngineName { get; init; }

            /// <summary>
            /// <para>
            /// The version of the engine.
            /// </para>
            /// </summary>
            public (int, int, int) EngineVersion { get; init; }

            /// <summary>
            /// The <c>pNext</c> chain components for <see cref="VkApplicationInfo"/>.
            /// </summary>
            /// <seealso cref="INext{TAbout}"/>
            public unsafe IEnumerable<INext<VkApplicationInfo>> AppNexts { get; init; } = Enumerable.Empty<INext<VkApplicationInfo>>();

            /// <summary>
            /// The <c>pNext</c> chain components for <see cref="VkInstanceCreateInfo"/>.
            /// </summary>
            /// <seealso cref="INext{TAbout}"/>
            public unsafe IEnumerable<INext<VkInstanceCreateInfo>> ApiNexts { get; init; } = Enumerable.Empty<INext<VkInstanceCreateInfo>>();
        }

        #endregion
        
        #region Instance Members

        private VkInstance apiHandle;

        /// <summary>
        /// Callback for validation messages.
        /// </summary>
        public event DebugCallback DebugCallback;

        private unsafe VkBool32 InternalDebugCallback(VkDebugUtilsMessageSeverityFlags severity, VkDebugUtilsMessageTypeFlags types, VkDebugUtilsMessengerCallbackData* callbackData, void* userData)
        {
            DebugCallback?.Invoke(severity, types, *callbackData);
            return true;
        }

        private IEnumerable<PhysicalDevice> physicalDevices;

        /// <summary>
        /// All of the existing physical devices in the current environment.
        /// </summary>
        public IEnumerable<PhysicalDevice> PhysicalDevices
        {
            get
            {
                if(physicalDevices == null)
                {
                    uint count = 0;
                    Vk.EnumeratePhysicalDevices(apiHandle, ref count, null);
                    var array = new VkPhysicalDevice[count];
                    Vk.EnumeratePhysicalDevices(apiHandle, ref count, array);
                    physicalDevices = from handle in array
                                      select new PhysicalDevice(handle, this);
                }
                return physicalDevices;
            }
        }

        #endregion

        #region Constructors

        public unsafe VulkanApi(Info info)
        {
            var extensionData = info.ApiExtensions.Union(debugExtensions).ToArray();
            var layerData = info.ApiLayers.ToArray();

            var appInfo = new VkApplicationInfo
            {
                StructureType = VkStructureType.ApplicationInfo,

                ApiVersion = info.ApiVersion.ComposeVersion(),

                ApplicationName = info.AppName.Pin(Encoding.UTF8),
                ApplicationVersion = info.AppVersion.ComposeVersion(),
                
                EngineName = info.EngineName.Pin(Encoding.UTF8),
                EngineVersion = info.EngineVersion.ComposeVersion(),
                
                Next = info.AppNexts.MakeChain()
            };

            var debugInfo = new VkDebugUtilsMessengerCreateInfo
            {
                StructureType = VkStructureType.DebugUtilsMessengerCreateInfoExt,

                Flags = info.DebugFlags,

                MessageType = info.DebugMessageTypes,
                MessageSeverity = info.DebugMessageSeverities,

                UserCallbackMethod = InternalDebugCallback,
                UserData = null,

                Next = info.ApiNexts.MakeChain()
            };

            var apiInfo = new VkInstanceCreateInfo
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
                Vk.CreateInstance(ref apiInfo, null, out apiHandle);
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

        public PhysicalDevice GetAnyDevice()
            => PhysicalDevices.FirstOrDefault() ?? throw new NotSupportedException(ExceptionMessages.DeviceNotFound);

        #endregion

        #region Destructors

        private List<IDisposable> disposables = new List<IDisposable>();

        public void AddPreviousDisposable(IDisposable x)
            => disposables.Add(x);

        private bool disposedValue;

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if(disposing)
                {
                    foreach(var disposal in disposables)
                        disposal.Dispose();
                }
                Vk.DestroyInstance(apiHandle, (VkAllocationCallbacks[])null);
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

        /// <summary>
        /// All of the supported instance extensions in the current environment.
        /// </summary>
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

        /// <summary>
        /// Checks if an extension is supported in the current environment.
        /// </summary>
        /// <param name="name">The name of the extension</param>
        /// <returns><c>true</c> if and only if the extension is supported</returns>
        public static bool IsSupportedExtension(string name)
            => SupportedExtensions.Contains(name);

        /// <summary>
        /// Checks if extensions are supported in the current environment.
        /// </summary>
        /// <param name="names">The names of the extensions.</param>
        /// <returns><c>true</c> if and only if all of the extensions are supported.</returns>
        public static bool IsSupportedExtensions(IEnumerable<string> names)
            => names.All((name) => SupportedExtensions.Contains(name));

        private static IEnumerable<string> layers;

        /// <summary>
        /// All of the supported Vulkan instance validation layers in the current environment.
        /// </summary>
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

        /// <summary>
        /// Checks if a validation layer is supported in the current environment.
        /// </summary>
        /// <param name="name">The name of the validation layer</param>
        /// <returns><c>true</c> if and only if the validation layers is supported</returns>
        public static bool IsSupportedLayer(string name)
            => SupportedLayers.Contains(name);

        /// <summary>
        /// Checks if validation layers are supported in the current environment.
        /// </summary>
        /// <param name="names">The names of the validation layers.</param>
        /// <returns><c>true</c> if and only if all of the validation layers are supported.</returns>
        public static bool IsSupportedLayers(IEnumerable<string> names)
            => names.All((name) => SupportedLayers.Contains(name));

        #endregion

    }
}
