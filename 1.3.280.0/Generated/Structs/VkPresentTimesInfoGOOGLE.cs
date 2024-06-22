using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPresentTimesInfoGOOGLE
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentTimeGOOGLE* pTimes;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPresentTimesInfoGOOGLE Create()
        {
            VkPresentTimesInfoGOOGLE ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
