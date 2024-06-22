using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoH265PredictorPaletteEntries
    {
        public fixed ushort PredictorPaletteEntries[384];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoH265PredictorPaletteEntries Create()
        {
            return default;
        }
        
    }
}
