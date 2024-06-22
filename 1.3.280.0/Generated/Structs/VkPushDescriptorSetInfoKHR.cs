using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPushDescriptorSetInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags stageFlags;
        public VkPipelineLayout layout;
        public uint set;
        public uint descriptorWriteCount;
        public VkWriteDescriptorSet* pDescriptorWrites;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPushDescriptorSetInfoKHR Create()
        {
            VkPushDescriptorSetInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
