using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassInputAttachmentAspectCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint aspectReferenceCount;
        public VkInputAttachmentAspectReference* pAspectReferences;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassInputAttachmentAspectCreateInfo Create()
        {
            VkRenderPassInputAttachmentAspectCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
