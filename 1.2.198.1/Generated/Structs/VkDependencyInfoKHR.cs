using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDependencyInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDependencyFlags dependencyFlags;
        public uint memoryBarrierCount;
        public VkMemoryBarrier2KHR* pMemoryBarriers;
        public uint bufferMemoryBarrierCount;
        public VkBufferMemoryBarrier2KHR* pBufferMemoryBarriers;
        public uint imageMemoryBarrierCount;
        public VkImageMemoryBarrier2KHR* pImageMemoryBarriers;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEPENDENCY_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDependencyInfoKHR Create()
        {
            VkDependencyInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
