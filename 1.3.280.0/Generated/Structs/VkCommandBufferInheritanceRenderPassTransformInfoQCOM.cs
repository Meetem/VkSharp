using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagsKHR transform;
        public VkRect2D renderArea;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCommandBufferInheritanceRenderPassTransformInfoQCOM Create()
        {
            VkCommandBufferInheritanceRenderPassTransformInfoQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
