using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineExecutableStatisticKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte name[256];
        public fixed byte description[256];
        public VkPipelineExecutableStatisticFormatKHR format;
        public VkPipelineExecutableStatisticValueKHR value;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineExecutableStatisticKHR Create()
        {
            VkPipelineExecutableStatisticKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
