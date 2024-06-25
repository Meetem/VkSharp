using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineDiscardRectangleStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineDiscardRectangleStateCreateFlagsEXT flags;
        public VkDiscardRectangleModeEXT discardRectangleMode;
        public uint discardRectangleCount;
        public VkRect2D* pDiscardRectangles;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineDiscardRectangleStateCreateInfoEXT Create()
        {
            VkPipelineDiscardRectangleStateCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
