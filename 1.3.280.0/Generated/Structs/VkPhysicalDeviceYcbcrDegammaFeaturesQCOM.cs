using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceYcbcrDegammaFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 ycbcrDegamma;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_DEGAMMA_FEATURES_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceYcbcrDegammaFeaturesQCOM Create()
        {
            VkPhysicalDeviceYcbcrDegammaFeaturesQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
