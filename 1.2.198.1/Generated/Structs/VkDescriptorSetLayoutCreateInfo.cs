using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorSetLayoutCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSetLayoutCreateFlags flags;
        public uint bindingCount;
        public VkDescriptorSetLayoutBinding* pBindings;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorSetLayoutCreateInfo Create()
        {
            VkDescriptorSetLayoutCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
