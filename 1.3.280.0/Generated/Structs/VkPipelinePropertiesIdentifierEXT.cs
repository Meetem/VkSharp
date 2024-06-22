using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelinePropertiesIdentifierEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte pipelineIdentifier[16];
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_PROPERTIES_IDENTIFIER_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelinePropertiesIdentifierEXT Create()
        {
            VkPipelinePropertiesIdentifierEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
