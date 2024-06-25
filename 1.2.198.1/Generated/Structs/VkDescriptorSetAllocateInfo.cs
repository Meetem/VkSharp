using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorSetAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorPool descriptorPool;
        public uint descriptorSetCount;
        public VkDescriptorSetLayout* pSetLayouts;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorSetAllocateInfo Create()
        {
            VkDescriptorSetAllocateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
