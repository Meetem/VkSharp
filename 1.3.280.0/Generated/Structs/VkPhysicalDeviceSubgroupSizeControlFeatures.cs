using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 subgroupSizeControl;
        public VkBool32 computeFullSubgroups;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceSubgroupSizeControlFeatures Create()
        {
            VkPhysicalDeviceSubgroupSizeControlFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
