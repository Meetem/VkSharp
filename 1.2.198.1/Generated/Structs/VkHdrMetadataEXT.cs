using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkHdrMetadataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkXYColorEXT displayPrimaryRed;
        public VkXYColorEXT displayPrimaryGreen;
        public VkXYColorEXT displayPrimaryBlue;
        public VkXYColorEXT whitePoint;
        public float maxLuminance;
        public float minLuminance;
        public float maxContentLightLevel;
        public float maxFrameAverageLightLevel;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_HDR_METADATA_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkHdrMetadataEXT Create()
        {
            VkHdrMetadataEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
