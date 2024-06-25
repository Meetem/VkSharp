using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineCoverageModulationStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCoverageModulationStateCreateFlagsNV flags;
        public VkCoverageModulationModeNV coverageModulationMode;
        public VkBool32 coverageModulationTableEnable;
        public uint coverageModulationTableCount;
        public float* pCoverageModulationTable;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineCoverageModulationStateCreateInfoNV Create()
        {
            VkPipelineCoverageModulationStateCreateInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
