using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1Quantization
    {
        public StdVideoAV1QuantizationFlags flags;
        public byte base_q_idx;
        public byte DeltaQYDc;
        public byte DeltaQUDc;
        public byte DeltaQUAc;
        public byte DeltaQVDc;
        public byte DeltaQVAc;
        public byte qm_y;
        public byte qm_u;
        public byte qm_v;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1Quantization Create()
        {
            return default;
        }
        
    }
}
