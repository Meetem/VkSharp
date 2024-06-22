using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorSetLayoutHostMappingInfoVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong descriptorOffset;
        public uint descriptorSize;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorSetLayoutHostMappingInfoVALVE Create()
        {
            VkDescriptorSetLayoutHostMappingInfoVALVE ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
