using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindPipelineIndirectCommandNV
    {
        public ulong pipelineAddress;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindPipelineIndirectCommandNV Create()
        {
            return default;
        }
        
    }
}
