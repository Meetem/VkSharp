using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPresentRegionsKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentRegionKHR* pRegions;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPresentRegionsKHR Create()
        {
            VkPresentRegionsKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
