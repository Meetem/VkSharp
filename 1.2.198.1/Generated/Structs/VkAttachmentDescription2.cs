using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAttachmentDescription2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAttachmentDescriptionFlags flags;
        public VkFormat format;
        public VkSampleCountFlags samples;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkAttachmentLoadOp stencilLoadOp;
        public VkAttachmentStoreOp stencilStoreOp;
        public VkImageLayout initialLayout;
        public VkImageLayout finalLayout;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAttachmentDescription2 Create()
        {
            return default;
        }
        
    }
}
