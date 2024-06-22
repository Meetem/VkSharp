using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoCodecOperationFlagsKHR videoCodecOperation;
        public VkVideoChromaSubsamplingFlagsKHR chromaSubsampling;
        public VkVideoComponentBitDepthFlagsKHR lumaBitDepth;
        public VkVideoComponentBitDepthFlagsKHR chromaBitDepth;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoProfileInfoKHR Create()
        {
            VkVideoProfileInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
