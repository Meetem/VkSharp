using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassTransformBeginInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagsKHR transform;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassTransformBeginInfoQCOM Create()
        {
            VkRenderPassTransformBeginInfoQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
