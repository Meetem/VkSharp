using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSamplerCubicWeightsCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCubicFilterWeightsQCOM cubicWeights;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_CUBIC_WEIGHTS_CREATE_INFO_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSamplerCubicWeightsCreateInfoQCOM Create()
        {
            VkSamplerCubicWeightsCreateInfoQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
