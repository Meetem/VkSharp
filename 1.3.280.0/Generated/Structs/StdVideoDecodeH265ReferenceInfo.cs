using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoDecodeH265ReferenceInfo
    {
        public StdVideoDecodeH265ReferenceInfoFlags flags;
        public int PicOrderCntVal;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoDecodeH265ReferenceInfo Create()
        {
            return default;
        }
        
    }
}
