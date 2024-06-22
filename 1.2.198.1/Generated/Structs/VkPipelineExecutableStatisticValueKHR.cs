using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkPipelineExecutableStatisticValueKHR
    {
        [FieldOffset(0)]
        public VkBool32 b32;
        [FieldOffset(0)]
        public long i64;
        [FieldOffset(0)]
        public ulong u64;
        [FieldOffset(0)]
        public double f64;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineExecutableStatisticValueKHR Create()
        {
            return default;
        }
        
    }
}
