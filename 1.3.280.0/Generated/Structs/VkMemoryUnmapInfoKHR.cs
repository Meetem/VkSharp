using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryUnmapInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryUnmapFlagsKHR flags;
        public VkDeviceMemory memory;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryUnmapInfoKHR Create()
        {
            VkMemoryUnmapInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
