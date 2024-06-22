using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageCompressionPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCompressionFlagsEXT imageCompressionFlags;
        public VkImageCompressionFixedRateFlagsEXT imageCompressionFixedRateFlags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageCompressionPropertiesEXT Create()
        {
            VkImageCompressionPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
