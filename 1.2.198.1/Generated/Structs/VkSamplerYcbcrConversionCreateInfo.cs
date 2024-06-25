using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSamplerYcbcrConversionCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkSamplerYcbcrModelConversion ycbcrModel;
        public VkSamplerYcbcrRange ycbcrRange;
        public VkComponentMapping components;
        public VkChromaLocation xChromaOffset;
        public VkChromaLocation yChromaOffset;
        public VkFilter chromaFilter;
        public VkBool32 forceExplicitReconstruction;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSamplerYcbcrConversionCreateInfo Create()
        {
            VkSamplerYcbcrConversionCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
