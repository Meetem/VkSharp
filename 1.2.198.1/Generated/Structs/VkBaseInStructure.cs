using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBaseInStructure
    {
        public VkStructureType sType;
        public VkBaseInStructure* pNext;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBaseInStructure Create()
        {
            return default;
        }
        
    }
}
