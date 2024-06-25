using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkFormatProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormatProperties formatProperties;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkFormatProperties2 Create()
        {
            return default;
        }
        
    }
}
