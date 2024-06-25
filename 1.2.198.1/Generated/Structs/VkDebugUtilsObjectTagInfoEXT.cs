using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDebugUtilsObjectTagInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkObjectType objectType;
        public ulong objectHandle;
        public ulong tagName;
        public ulong tagSize;
        public void* pTag;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDebugUtilsObjectTagInfoEXT Create()
        {
            VkDebugUtilsObjectTagInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
