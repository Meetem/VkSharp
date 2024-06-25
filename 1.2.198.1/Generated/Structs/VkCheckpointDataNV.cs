using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCheckpointDataNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags stage;
        public void* pCheckpointMarker;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCheckpointDataNV Create()
        {
            VkCheckpointDataNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
