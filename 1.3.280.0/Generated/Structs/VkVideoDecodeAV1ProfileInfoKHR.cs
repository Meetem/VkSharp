using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeAV1ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoAV1Profile stdProfile;
        public VkBool32 filmGrainSupport;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PROFILE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeAV1ProfileInfoKHR Create()
        {
            VkVideoDecodeAV1ProfileInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
