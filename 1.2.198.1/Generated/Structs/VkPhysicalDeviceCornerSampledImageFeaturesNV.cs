using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceCornerSampledImageFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cornerSampledImage;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceCornerSampledImageFeaturesNV Create()
        {
            VkPhysicalDeviceCornerSampledImageFeaturesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
