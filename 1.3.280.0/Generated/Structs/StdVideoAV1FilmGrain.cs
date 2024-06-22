using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1FilmGrain
    {
        public StdVideoAV1FilmGrainFlags flags;
        public byte grain_scaling_minus_8;
        public byte ar_coeff_lag;
        public byte ar_coeff_shift_minus_6;
        public byte grain_scale_shift;
        public ushort grain_seed;
        public byte film_grain_params_ref_idx;
        public byte num_y_points;
        public fixed byte point_y_value[14];
        public fixed byte point_y_scaling[14];
        public byte num_cb_points;
        public fixed byte point_cb_value[10];
        public fixed byte point_cb_scaling[10];
        public byte num_cr_points;
        public fixed byte point_cr_value[10];
        public fixed byte point_cr_scaling[10];
        public fixed byte ar_coeffs_y_plus_128[24];
        public fixed byte ar_coeffs_cb_plus_128[25];
        public fixed byte ar_coeffs_cr_plus_128[25];
        public byte cb_mult;
        public byte cb_luma_mult;
        public ushort cb_offset;
        public byte cr_mult;
        public byte cr_luma_mult;
        public ushort cr_offset;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1FilmGrain Create()
        {
            return default;
        }
        
    }
}
