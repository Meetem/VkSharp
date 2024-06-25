using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkQueueFamilyCheckpointProperties2NV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2KHR checkpointExecutionStageMask;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkQueueFamilyCheckpointProperties2NV Create()
        {
            return default;
        }
        
    }
}
