using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkClearDepthStencilValue
    {
        public float depth;
        public uint stencil;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkClearDepthStencilValue Create()
        {
            return default;
        }
        
    }
}
