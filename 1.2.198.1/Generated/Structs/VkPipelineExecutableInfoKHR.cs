using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineExecutableInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipeline pipeline;
        public uint executableIndex;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineExecutableInfoKHR Create()
        {
            VkPipelineExecutableInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
