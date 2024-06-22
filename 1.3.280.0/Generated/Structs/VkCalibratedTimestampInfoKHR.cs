using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCalibratedTimestampInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTimeDomainKHR timeDomain;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCalibratedTimestampInfoKHR Create()
        {
            VkCalibratedTimestampInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
