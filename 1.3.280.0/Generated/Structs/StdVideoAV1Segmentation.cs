using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1Segmentation
    {
        public fixed byte FeatureEnabled[8];
        public fixed short FeatureData[64];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1Segmentation Create()
        {
            return default;
        }
        
    }
}
