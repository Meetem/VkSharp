using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeAV1PictureInfo
    {
        public StdVideoDecodeAV1PictureInfoFlags flags;
        public StdVideoAV1FrameType frame_type;
        public uint current_frame_id;
        public byte OrderHint;
        public byte primary_ref_frame;
        public byte refresh_frame_flags;
        public byte reserved1;
        public StdVideoAV1InterpolationFilter interpolation_filter;
        public StdVideoAV1TxMode TxMode;
        public byte delta_q_res;
        public byte delta_lf_res;
        public fixed byte SkipModeFrame[2];
        public byte coded_denom;
        public fixed byte reserved2[3];
        public fixed byte OrderHints[8];
        public fixed uint expectedFrameId[8];
        public StdVideoAV1TileInfo* pTileInfo;
        public StdVideoAV1Quantization* pQuantization;
        public StdVideoAV1Segmentation* pSegmentation;
        public StdVideoAV1LoopFilter* pLoopFilter;
        public StdVideoAV1CDEF* pCDEF;
        public StdVideoAV1LoopRestoration* pLoopRestoration;
        public StdVideoAV1GlobalMotion* pGlobalMotion;
        public StdVideoAV1FilmGrain* pFilmGrain;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeAV1PictureInfo Create()
        {
            return default;
        }
        
    }
}
