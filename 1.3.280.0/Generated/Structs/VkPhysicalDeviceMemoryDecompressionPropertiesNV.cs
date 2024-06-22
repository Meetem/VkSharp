using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMemoryDecompressionPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryDecompressionMethodFlagsNV decompressionMethods;
        public ulong maxDecompressionIndirectCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMemoryDecompressionPropertiesNV Create()
        {
            VkPhysicalDeviceMemoryDecompressionPropertiesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
