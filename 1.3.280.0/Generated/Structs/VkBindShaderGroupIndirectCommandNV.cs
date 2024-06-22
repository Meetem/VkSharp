using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindShaderGroupIndirectCommandNV
    {
        public uint groupIndex;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindShaderGroupIndirectCommandNV Create()
        {
            return default;
        }
        
    }
}
