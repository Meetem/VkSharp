using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineCreationFeedbackCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreationFeedbackEXT* pPipelineCreationFeedback;
        public uint pipelineStageCreationFeedbackCount;
        public VkPipelineCreationFeedbackEXT* pPipelineStageCreationFeedbacks;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineCreationFeedbackCreateInfoEXT Create()
        {
            VkPipelineCreationFeedbackCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
