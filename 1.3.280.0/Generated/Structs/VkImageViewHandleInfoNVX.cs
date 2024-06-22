using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageViewHandleInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkDescriptorType descriptorType;
        public VkSampler sampler;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageViewHandleInfoNVX Create()
        {
            VkImageViewHandleInfoNVX ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
