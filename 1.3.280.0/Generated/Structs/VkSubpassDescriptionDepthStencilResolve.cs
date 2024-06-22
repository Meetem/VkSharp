using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSubpassDescriptionDepthStencilResolve
    {
        public VkStructureType sType;
        public void* pNext;
        public VkResolveModeFlags depthResolveMode;
        public VkResolveModeFlags stencilResolveMode;
        public VkAttachmentReference2* pDepthStencilResolveAttachment;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSubpassDescriptionDepthStencilResolve Create()
        {
            VkSubpassDescriptionDepthStencilResolve ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
