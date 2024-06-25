using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageFormatProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageFormatProperties imageFormatProperties;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageFormatProperties2 Create()
        {
            return default;
        }
        
    }
}
