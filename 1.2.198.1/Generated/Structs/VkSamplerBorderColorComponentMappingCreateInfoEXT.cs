using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSamplerBorderColorComponentMappingCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkComponentMapping components;
        public VkBool32 srgb;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSamplerBorderColorComponentMappingCreateInfoEXT Create()
        {
            VkSamplerBorderColorComponentMappingCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
