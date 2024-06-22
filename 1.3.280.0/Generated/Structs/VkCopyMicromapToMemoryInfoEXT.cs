using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyMicromapToMemoryInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMicromapEXT src;
        public VkDeviceOrHostAddressKHR dst;
        public VkCopyMicromapModeEXT mode;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyMicromapToMemoryInfoEXT Create()
        {
            VkCopyMicromapToMemoryInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
