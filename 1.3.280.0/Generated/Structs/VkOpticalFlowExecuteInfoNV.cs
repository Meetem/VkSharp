using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkOpticalFlowExecuteInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOpticalFlowExecuteFlagsNV flags;
        public uint regionCount;
        public VkRect2D* pRegions;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_OPTICAL_FLOW_EXECUTE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkOpticalFlowExecuteInfoNV Create()
        {
            VkOpticalFlowExecuteInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
