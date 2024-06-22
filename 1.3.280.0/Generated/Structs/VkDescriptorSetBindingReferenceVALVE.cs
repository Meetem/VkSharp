using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorSetBindingReferenceVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSetLayout descriptorSetLayout;
        public uint binding;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorSetBindingReferenceVALVE Create()
        {
            VkDescriptorSetBindingReferenceVALVE ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
