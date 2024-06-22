using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassSubpassFeedbackCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassSubpassFeedbackInfoEXT* pSubpassFeedback;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassSubpassFeedbackCreateInfoEXT Create()
        {
            VkRenderPassSubpassFeedbackCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
