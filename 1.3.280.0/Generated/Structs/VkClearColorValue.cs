using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkClearColorValue
    {
        [FieldOffset(0)]
        public fixed float float32[4];
        [FieldOffset(0)]
        public fixed int int32[4];
        [FieldOffset(0)]
        public fixed uint uint32[4];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkClearColorValue Create()
        {
            return default;
        }
        
    }
}
