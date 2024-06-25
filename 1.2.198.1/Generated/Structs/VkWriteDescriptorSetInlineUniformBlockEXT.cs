using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkWriteDescriptorSetInlineUniformBlockEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint dataSize;
        public void* pData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkWriteDescriptorSetInlineUniformBlockEXT Create()
        {
            VkWriteDescriptorSetInlineUniformBlockEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
