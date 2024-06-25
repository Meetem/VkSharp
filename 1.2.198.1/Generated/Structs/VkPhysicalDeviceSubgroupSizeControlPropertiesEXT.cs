using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minSubgroupSize;
        public uint maxSubgroupSize;
        public uint maxComputeWorkgroupSubgroups;
        public VkShaderStageFlags requiredSubgroupSizeStages;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceSubgroupSizeControlPropertiesEXT Create()
        {
            VkPhysicalDeviceSubgroupSizeControlPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
