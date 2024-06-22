using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkWriteDescriptorSetInlineUniformBlock
    {
        public VkStructureType sType;
        public void* pNext;
        public uint dataSize;
        public void* pData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkWriteDescriptorSetInlineUniformBlock Create()
        {
            VkWriteDescriptorSetInlineUniformBlock ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
