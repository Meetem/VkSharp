using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMappedMemoryRange
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public ulong offset;
        public ulong size;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMappedMemoryRange Create()
        {
            VkMappedMemoryRange ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
