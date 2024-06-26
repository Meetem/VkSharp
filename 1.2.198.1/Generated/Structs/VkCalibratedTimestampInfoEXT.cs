using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCalibratedTimestampInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTimeDomainEXT timeDomain;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCalibratedTimestampInfoEXT Create()
        {
            VkCalibratedTimestampInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
