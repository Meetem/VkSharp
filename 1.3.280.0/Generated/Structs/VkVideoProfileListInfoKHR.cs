using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoProfileListInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint profileCount;
        public VkVideoProfileInfoKHR* pProfiles;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoProfileListInfoKHR Create()
        {
            VkVideoProfileListInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
