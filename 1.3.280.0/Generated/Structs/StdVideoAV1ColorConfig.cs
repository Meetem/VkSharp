using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1ColorConfig
    {
        public StdVideoAV1ColorConfigFlags flags;
        public byte BitDepth;
        public byte subsampling_x;
        public byte subsampling_y;
        public byte reserved1;
        public StdVideoAV1ColorPrimaries color_primaries;
        public StdVideoAV1TransferCharacteristics transfer_characteristics;
        public StdVideoAV1MatrixCoefficients matrix_coefficients;
        public StdVideoAV1ChromaSamplePosition chroma_sample_position;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1ColorConfig Create()
        {
            return default;
        }
        
    }
}
