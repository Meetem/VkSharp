using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDebugMarkerObjectTagInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugReportObjectTypeEXT objectType;
        public ulong _object;
        public ulong tagName;
        public ulong tagSize;
        public void* pTag;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDebugMarkerObjectTagInfoEXT Create()
        {
            VkDebugMarkerObjectTagInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
