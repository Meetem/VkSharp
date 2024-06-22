using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkGraphicsPipelineLibraryCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkGraphicsPipelineLibraryFlagsEXT flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkGraphicsPipelineLibraryCreateInfoEXT Create()
        {
            VkGraphicsPipelineLibraryCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
