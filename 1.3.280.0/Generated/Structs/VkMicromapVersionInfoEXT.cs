using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMicromapVersionInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pVersionData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMicromapVersionInfoEXT Create()
        {
            VkMicromapVersionInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
