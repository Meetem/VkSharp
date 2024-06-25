using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryAllocateFlagsInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryAllocateFlags flags;
        public uint deviceMask;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryAllocateFlagsInfo Create()
        {
            VkMemoryAllocateFlagsInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
