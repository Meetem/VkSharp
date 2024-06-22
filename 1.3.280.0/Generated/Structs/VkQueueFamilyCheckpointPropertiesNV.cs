using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkQueueFamilyCheckpointPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags checkpointExecutionStageMask;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkQueueFamilyCheckpointPropertiesNV Create()
        {
            VkQueueFamilyCheckpointPropertiesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
