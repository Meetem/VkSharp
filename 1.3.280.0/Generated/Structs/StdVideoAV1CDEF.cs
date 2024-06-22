using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1CDEF
    {
        public byte cdef_damping_minus_3;
        public byte cdef_bits;
        public fixed byte cdef_y_pri_strength[8];
        public fixed byte cdef_y_sec_strength[8];
        public fixed byte cdef_uv_pri_strength[8];
        public fixed byte cdef_uv_sec_strength[8];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1CDEF Create()
        {
            return default;
        }
        
    }
}
