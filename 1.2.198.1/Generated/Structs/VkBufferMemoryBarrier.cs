using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBufferMemoryBarrier
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBufferMemoryBarrier Create()
        {
            VkBufferMemoryBarrier ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
