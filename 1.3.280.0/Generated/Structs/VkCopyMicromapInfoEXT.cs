using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyMicromapInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMicromapEXT src;
        public VkMicromapEXT dst;
        public VkCopyMicromapModeEXT mode;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyMicromapInfoEXT Create()
        {
            VkCopyMicromapInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
