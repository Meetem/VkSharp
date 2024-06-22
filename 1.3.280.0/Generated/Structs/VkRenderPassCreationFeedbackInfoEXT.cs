using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassCreationFeedbackInfoEXT
    {
        public uint postMergeSubpassCount;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassCreationFeedbackInfoEXT Create()
        {
            return default;
        }
        
    }
}
