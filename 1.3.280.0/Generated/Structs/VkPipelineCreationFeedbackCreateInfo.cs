using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineCreationFeedbackCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreationFeedback* pPipelineCreationFeedback;
        public uint pipelineStageCreationFeedbackCount;
        public VkPipelineCreationFeedback* pPipelineStageCreationFeedbacks;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineCreationFeedbackCreateInfo Create()
        {
            VkPipelineCreationFeedbackCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
