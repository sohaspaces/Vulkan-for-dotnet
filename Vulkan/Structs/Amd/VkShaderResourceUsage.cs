using System.Runtime.InteropServices;
namespace Vulkan.Structs.Amd
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkShaderResourceUsage
    {
        public uint NumUsedVgprs { get; init; }

        public uint NumUsedSgprs { get; init; }

        public uint LdsSizePerLocalWorkGroup { get; init; }



        public nuint LdsUsageSizeInBytes { get; init; }



        public nuint ScratchMemUsageInBytes { get; init; }
    }
}
