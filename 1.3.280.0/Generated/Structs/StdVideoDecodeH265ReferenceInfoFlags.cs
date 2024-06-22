using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeH265ReferenceInfoFlags
    {
        public uint used_for_long_term_reference;
        public uint unused_for_reference;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeH265ReferenceInfoFlags Create()
        {
            return default;
        }
        
    }
}
