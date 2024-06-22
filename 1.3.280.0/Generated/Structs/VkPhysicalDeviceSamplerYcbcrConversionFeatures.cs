using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 samplerYcbcrConversion;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceSamplerYcbcrConversionFeatures Create()
        {
            VkPhysicalDeviceSamplerYcbcrConversionFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
