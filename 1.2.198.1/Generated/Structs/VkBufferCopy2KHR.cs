using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBufferCopy2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong srcOffset;
        public ulong dstOffset;
        public ulong size;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBufferCopy2KHR Create()
        {
            return default;
        }
        
    }
}
