using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkWriteDescriptorSet
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public VkDescriptorType descriptorType;
        public VkDescriptorImageInfo* pImageInfo;
        public VkDescriptorBufferInfo* pBufferInfo;
        public VkBufferView* pTexelBufferView;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkWriteDescriptorSet Create()
        {
            VkWriteDescriptorSet ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
