using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDependencyInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDependencyFlags dependencyFlags;
        public uint memoryBarrierCount;
        public VkMemoryBarrier2* pMemoryBarriers;
        public uint bufferMemoryBarrierCount;
        public VkBufferMemoryBarrier2* pBufferMemoryBarriers;
        public uint imageMemoryBarrierCount;
        public VkImageMemoryBarrier2* pImageMemoryBarriers;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEPENDENCY_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDependencyInfo Create()
        {
            VkDependencyInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
