using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkPerformanceCounterResultKHR
    {
        [FieldOffset(0)]
        public int int32;
        [FieldOffset(0)]
        public long int64;
        [FieldOffset(0)]
        public uint uint32;
        [FieldOffset(0)]
        public ulong uint64;
        [FieldOffset(0)]
        public float float32;
        [FieldOffset(0)]
        public double float64;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPerformanceCounterResultKHR Create()
        {
            return default;
        }
        
    }
}
