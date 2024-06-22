using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoAV1TileInfo
    {
        public StdVideoAV1TileInfoFlags flags;
        public byte TileCols;
        public byte TileRows;
        public ushort context_update_tile_id;
        public byte tile_size_bytes_minus_1;
        public fixed byte reserved1[7];
        public ushort* pMiColStarts;
        public ushort* pMiRowStarts;
        public ushort* pWidthInSbsMinus1;
        public ushort* pHeightInSbsMinus1;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoAV1TileInfo Create()
        {
            return default;
        }
        
    }
}
