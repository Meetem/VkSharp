using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineRasterizationStateStreamCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
        public uint rasterizationStream;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineRasterizationStateStreamCreateInfoEXT Create()
        {
            VkPipelineRasterizationStateStreamCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
