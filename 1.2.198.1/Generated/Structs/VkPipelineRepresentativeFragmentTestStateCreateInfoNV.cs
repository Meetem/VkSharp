using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 representativeFragmentTestEnable;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineRepresentativeFragmentTestStateCreateInfoNV Create()
        {
            VkPipelineRepresentativeFragmentTestStateCreateInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
