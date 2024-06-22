using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryMapPlacedInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pPlacedAddress;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_MAP_PLACED_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryMapPlacedInfoEXT Create()
        {
            VkMemoryMapPlacedInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
