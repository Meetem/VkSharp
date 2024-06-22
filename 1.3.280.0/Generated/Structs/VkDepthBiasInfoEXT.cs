using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDepthBiasInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public float depthBiasConstantFactor;
        public float depthBiasClamp;
        public float depthBiasSlopeFactor;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEPTH_BIAS_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDepthBiasInfoEXT Create()
        {
            VkDepthBiasInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
