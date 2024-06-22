using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceCubicWeightsFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 selectableCubicWeights;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_WEIGHTS_FEATURES_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceCubicWeightsFeaturesQCOM Create()
        {
            VkPhysicalDeviceCubicWeightsFeaturesQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
