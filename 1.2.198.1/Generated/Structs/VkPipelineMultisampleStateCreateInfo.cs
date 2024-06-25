using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineMultisampleStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineMultisampleStateCreateFlags flags;
        public VkSampleCountFlags rasterizationSamples;
        public VkBool32 sampleShadingEnable;
        public float minSampleShading;
        public uint* pSampleMask;
        public VkBool32 alphaToCoverageEnable;
        public VkBool32 alphaToOneEnable;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineMultisampleStateCreateInfo Create()
        {
            VkPipelineMultisampleStateCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
