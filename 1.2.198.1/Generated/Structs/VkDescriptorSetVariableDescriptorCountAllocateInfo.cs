using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorSetVariableDescriptorCountAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint descriptorSetCount;
        public uint* pDescriptorCounts;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorSetVariableDescriptorCountAllocateInfo Create()
        {
            VkDescriptorSetVariableDescriptorCountAllocateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
