using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDebugUtilsLabelEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pLabelName;
        public fixed float color[4];
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDebugUtilsLabelEXT Create()
        {
            VkDebugUtilsLabelEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
