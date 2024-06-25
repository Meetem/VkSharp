using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBaseOutStructure
    {
        public VkStructureType sType;
        public VkBaseOutStructure* pNext;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBaseOutStructure Create()
        {
            return default;
        }
        
    }
}
