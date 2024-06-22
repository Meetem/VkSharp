using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 enableYDegamma;
        public VkBool32 enableCbCrDegamma;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_YCBCR_DEGAMMA_CREATE_INFO_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM Create()
        {
            VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
