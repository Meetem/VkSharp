using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentDensityMapOffset;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM Create()
        {
            VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
