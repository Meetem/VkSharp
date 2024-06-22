using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264ReferenceInfoFlags
    {
        public uint used_for_long_term_reference;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264ReferenceInfoFlags Create()
        {
            return default;
        }
        
    }
}
