using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxInlineUniformBlockBindings;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorPoolInlineUniformBlockCreateInfoEXT Create()
        {
            VkDescriptorPoolInlineUniformBlockCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
