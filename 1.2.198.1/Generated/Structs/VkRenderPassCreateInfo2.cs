using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassCreateInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassCreateFlags flags;
        public uint attachmentCount;
        public VkAttachmentDescription2* pAttachments;
        public uint subpassCount;
        public VkSubpassDescription2* pSubpasses;
        public uint dependencyCount;
        public VkSubpassDependency2* pDependencies;
        public uint correlatedViewMaskCount;
        public uint* pCorrelatedViewMasks;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassCreateInfo2 Create()
        {
            return default;
        }
        
    }
}
