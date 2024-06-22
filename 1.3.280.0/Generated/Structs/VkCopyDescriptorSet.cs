using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyDescriptorSet
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSet srcSet;
        public uint srcBinding;
        public uint srcArrayElement;
        public VkDescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyDescriptorSet Create()
        {
            VkCopyDescriptorSet ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
