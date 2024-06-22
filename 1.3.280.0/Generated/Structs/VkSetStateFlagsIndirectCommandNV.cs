using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSetStateFlagsIndirectCommandNV
    {
        public uint data;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSetStateFlagsIndirectCommandNV Create()
        {
            return default;
        }
        
    }
}
