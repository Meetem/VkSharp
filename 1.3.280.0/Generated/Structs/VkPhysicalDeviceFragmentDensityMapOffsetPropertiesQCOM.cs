using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D fragmentDensityOffsetGranularity;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM Create()
        {
            VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
