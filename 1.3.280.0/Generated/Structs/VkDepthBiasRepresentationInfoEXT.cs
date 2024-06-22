using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDepthBiasRepresentationInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDepthBiasRepresentationEXT depthBiasRepresentation;
        public VkBool32 depthBiasExact;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEPTH_BIAS_REPRESENTATION_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDepthBiasRepresentationInfoEXT Create()
        {
            VkDepthBiasRepresentationInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
