using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageViewASTCDecodeModeEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat decodeMode;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageViewASTCDecodeModeEXT Create()
        {
            return default;
        }
        
    }
}
