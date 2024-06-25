using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryBarrier
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_BARRIER;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryBarrier Create()
        {
            VkMemoryBarrier ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
