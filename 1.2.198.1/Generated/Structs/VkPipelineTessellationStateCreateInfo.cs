using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineTessellationStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineTessellationStateCreateFlags flags;
        public uint patchControlPoints;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineTessellationStateCreateInfo Create()
        {
            VkPipelineTessellationStateCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
