using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryMapInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryMapFlags flags;
        public VkDeviceMemory memory;
        public ulong offset;
        public ulong size;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryMapInfoKHR Create()
        {
            VkMemoryMapInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
