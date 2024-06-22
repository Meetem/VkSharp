using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryDedicatedAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkBuffer buffer;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryDedicatedAllocateInfo Create()
        {
            VkMemoryDedicatedAllocateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
