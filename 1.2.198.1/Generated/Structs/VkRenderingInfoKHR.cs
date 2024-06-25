using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderingInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderingFlagsKHR flags;
        public VkRect2D renderArea;
        public uint layerCount;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkRenderingAttachmentInfoKHR* pColorAttachments;
        public VkRenderingAttachmentInfoKHR* pDepthAttachment;
        public VkRenderingAttachmentInfoKHR* pStencilAttachment;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDERING_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderingInfoKHR Create()
        {
            VkRenderingInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
