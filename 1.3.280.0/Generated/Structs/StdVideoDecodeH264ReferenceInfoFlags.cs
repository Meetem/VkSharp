using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeH264ReferenceInfoFlags
    {
        public uint top_field_flag;
        public uint bottom_field_flag;
        public uint used_for_long_term_reference;
        public uint is_non_existing;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeH264ReferenceInfoFlags Create()
        {
            return default;
        }
        
    }
}
