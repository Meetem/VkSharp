using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264PictureInfoFlags
    {
        public uint IdrPicFlag;
        public uint is_reference;
        public uint no_output_of_prior_pics_flag;
        public uint long_term_reference_flag;
        public uint adaptive_ref_pic_marking_mode_flag;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264PictureInfoFlags Create()
        {
            return default;
        }
        
    }
}
