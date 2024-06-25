using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineRasterizationLineStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkLineRasterizationModeEXT lineRasterizationMode;
        public VkBool32 stippledLineEnable;
        public uint lineStippleFactor;
        public ushort lineStipplePattern;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineRasterizationLineStateCreateInfoEXT Create()
        {
            VkPipelineRasterizationLineStateCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
