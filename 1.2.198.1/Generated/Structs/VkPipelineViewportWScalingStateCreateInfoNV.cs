using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineViewportWScalingStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 viewportWScalingEnable;
        public uint viewportCount;
        public VkViewportWScalingNV* pViewportWScalings;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineViewportWScalingStateCreateInfoNV Create()
        {
            return default;
        }
        
    }
}
