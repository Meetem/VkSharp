using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dedicatedAllocationImageAliasing;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV Create()
        {
            VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
