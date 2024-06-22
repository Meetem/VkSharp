using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageCaptureDescriptorDataInfoEXT Create()
        {
            VkImageCaptureDescriptorDataInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
