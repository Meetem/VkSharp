using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorSetVariableDescriptorCountLayoutSupport
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxVariableDescriptorCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorSetVariableDescriptorCountLayoutSupport Create()
        {
            VkDescriptorSetVariableDescriptorCountLayoutSupport ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
