using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkFragmentShadingRateAttachmentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAttachmentReference2* pFragmentShadingRateAttachment;
        public VkExtent2D shadingRateAttachmentTexelSize;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkFragmentShadingRateAttachmentInfoKHR Create()
        {
            VkFragmentShadingRateAttachmentInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
