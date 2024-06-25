using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSamplerYcbcrConversionInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerYcbcrConversion conversion;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSamplerYcbcrConversionInfo Create()
        {
            VkSamplerYcbcrConversionInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
