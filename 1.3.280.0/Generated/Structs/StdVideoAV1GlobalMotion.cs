using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1GlobalMotion
    {
        public fixed byte GmType[8];
        public fixed int gm_params[48];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1GlobalMotion Create()
        {
            return default;
        }
        
    }
}
