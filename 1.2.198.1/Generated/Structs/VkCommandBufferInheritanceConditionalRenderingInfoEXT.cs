using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 conditionalRenderingEnable;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCommandBufferInheritanceConditionalRenderingInfoEXT Create()
        {
            VkCommandBufferInheritanceConditionalRenderingInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
