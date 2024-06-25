using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCheckpointData2NV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2KHR stage;
        public void* pCheckpointMarker;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCheckpointData2NV Create()
        {
            return default;
        }
        
    }
}
