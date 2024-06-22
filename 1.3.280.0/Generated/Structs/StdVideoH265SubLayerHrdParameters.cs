using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265SubLayerHrdParameters
    {
        public fixed uint bit_rate_value_minus1[32];
        public fixed uint cpb_size_value_minus1[32];
        public fixed uint cpb_size_du_value_minus1[32];
        public fixed uint bit_rate_du_value_minus1[32];
        public uint cbr_flag;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265SubLayerHrdParameters Create()
        {
            return default;
        }
        
    }
}
