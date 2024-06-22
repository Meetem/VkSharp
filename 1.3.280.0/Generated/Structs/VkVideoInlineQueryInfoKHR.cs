using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoInlineQueryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueryPool queryPool;
        public uint firstQuery;
        public uint queryCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_INLINE_QUERY_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoInlineQueryInfoKHR Create()
        {
            VkVideoInlineQueryInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
