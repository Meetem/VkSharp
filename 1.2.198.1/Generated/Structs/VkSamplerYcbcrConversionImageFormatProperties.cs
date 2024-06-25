using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSamplerYcbcrConversionImageFormatProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint combinedImageSamplerDescriptorCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSamplerYcbcrConversionImageFormatProperties Create()
        {
            VkSamplerYcbcrConversionImageFormatProperties ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
