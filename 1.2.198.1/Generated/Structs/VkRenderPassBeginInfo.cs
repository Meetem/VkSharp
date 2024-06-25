using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPass renderPass;
        public VkFramebuffer framebuffer;
        public VkRect2D renderArea;
        public uint clearValueCount;
        public VkClearValue* pClearValues;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassBeginInfo Create()
        {
            VkRenderPassBeginInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
