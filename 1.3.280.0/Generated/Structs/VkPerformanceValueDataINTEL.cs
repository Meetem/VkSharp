using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkPerformanceValueDataINTEL
    {
        [FieldOffset(0)]
        public uint value32;
        [FieldOffset(0)]
        public ulong value64;
        [FieldOffset(0)]
        public float valueFloat;
        [FieldOffset(0)]
        public VkBool32 valueBool;
        [FieldOffset(0)]
        public byte* valueString;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPerformanceValueDataINTEL Create()
        {
            return default;
        }
        
    }
}
