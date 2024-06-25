using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAttachmentReference2
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachment;
        public VkImageLayout layout;
        public VkImageAspectFlags aspectMask;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAttachmentReference2 Create()
        {
            return default;
        }
        
    }
}
