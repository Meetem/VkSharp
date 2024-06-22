using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCommandBufferInheritanceViewportScissorInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 viewportScissor2D;
        public uint viewportDepthCount;
        public VkViewport* pViewportDepths;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCommandBufferInheritanceViewportScissorInfoNV Create()
        {
            VkCommandBufferInheritanceViewportScissorInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
