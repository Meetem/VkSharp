using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderingInputAttachmentIndexInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint colorAttachmentCount;
        public uint* pColorAttachmentInputIndices;
        public uint* pDepthInputAttachmentIndex;
        public uint* pStencilInputAttachmentIndex;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderingInputAttachmentIndexInfoKHR Create()
        {
            VkRenderingInputAttachmentIndexInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
