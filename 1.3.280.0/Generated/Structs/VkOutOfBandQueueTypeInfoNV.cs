using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkOutOfBandQueueTypeInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOutOfBandQueueTypeNV queueType;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_OUT_OF_BAND_QUEUE_TYPE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkOutOfBandQueueTypeInfoNV Create()
        {
            VkOutOfBandQueueTypeInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
