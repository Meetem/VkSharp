using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineCreationFeedback
    {
        public VkPipelineCreationFeedbackFlags flags;
        public ulong duration;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineCreationFeedback Create()
        {
            return default;
        }
        
    }
}
