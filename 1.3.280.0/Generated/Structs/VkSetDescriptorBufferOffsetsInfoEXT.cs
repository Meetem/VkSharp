using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSetDescriptorBufferOffsetsInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags stageFlags;
        public VkPipelineLayout layout;
        public uint firstSet;
        public uint setCount;
        public uint* pBufferIndices;
        public ulong* pOffsets;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SET_DESCRIPTOR_BUFFER_OFFSETS_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSetDescriptorBufferOffsetsInfoEXT Create()
        {
            VkSetDescriptorBufferOffsetsInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
