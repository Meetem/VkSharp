using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkConditionalRenderingBeginInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public ulong offset;
        public VkConditionalRenderingFlagsEXT flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkConditionalRenderingBeginInfoEXT Create()
        {
            VkConditionalRenderingBeginInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
