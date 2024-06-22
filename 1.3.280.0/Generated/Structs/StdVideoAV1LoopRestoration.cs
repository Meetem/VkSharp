using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1LoopRestoration
    {
        public FixedArrayStdVideoAV1FrameRestorationTypeSize3 FrameRestorationType;
        public fixed ushort LoopRestorationSize[3];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1LoopRestoration Create()
        {
            return default;
        }
        
    }
}
