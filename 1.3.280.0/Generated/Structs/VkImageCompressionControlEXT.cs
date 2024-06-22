using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageCompressionControlEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCompressionFlagsEXT flags;
        public uint compressionControlPlaneCount;
        public VkImageCompressionFixedRateFlagsEXT* pFixedRateFlags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageCompressionControlEXT Create()
        {
            VkImageCompressionControlEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
