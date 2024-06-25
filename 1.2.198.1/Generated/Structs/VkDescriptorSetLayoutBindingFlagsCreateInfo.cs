using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorSetLayoutBindingFlagsCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint bindingCount;
        public VkDescriptorBindingFlags* pBindingFlags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorSetLayoutBindingFlagsCreateInfo Create()
        {
            VkDescriptorSetLayoutBindingFlagsCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
