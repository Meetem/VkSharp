using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineCompilerControlCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCompilerControlFlagsAMD compilerControlFlags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineCompilerControlCreateInfoAMD Create()
        {
            VkPipelineCompilerControlCreateInfoAMD ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
