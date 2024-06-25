using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSubpassDescription2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubpassDescriptionFlags flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint viewMask;
        public uint inputAttachmentCount;
        public VkAttachmentReference2* pInputAttachments;
        public uint colorAttachmentCount;
        public VkAttachmentReference2* pColorAttachments;
        public VkAttachmentReference2* pResolveAttachments;
        public VkAttachmentReference2* pDepthStencilAttachment;
        public uint preserveAttachmentCount;
        public uint* pPreserveAttachments;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSubpassDescription2 Create()
        {
            return default;
        }
        
    }
}
