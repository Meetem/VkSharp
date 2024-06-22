using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkIndirectCommandsStreamNV
    {
        public VkBuffer buffer;
        public ulong offset;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkIndirectCommandsStreamNV Create()
        {
            return default;
        }
        
    }
}
