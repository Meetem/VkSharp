using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDrmFormatModifierPropertiesListEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDrmFormatModifierPropertiesListEXT Create()
        {
            VkDrmFormatModifierPropertiesListEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
