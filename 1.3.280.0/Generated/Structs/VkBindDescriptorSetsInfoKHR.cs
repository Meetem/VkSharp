using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkBindDescriptorSetsInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags stageFlags;
        public VkPipelineLayout layout;
        public uint firstSet;
        public uint descriptorSetCount;
        public VkDescriptorSet* pDescriptorSets;
        public uint dynamicOffsetCount;
        public uint* pDynamicOffsets;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkBindDescriptorSetsInfoKHR Create()
        {
            VkBindDescriptorSetsInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
