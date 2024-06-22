using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint perViewRenderAreaCount;
        public VkRect2D* pPerViewRenderAreas;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM Create()
        {
            VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
