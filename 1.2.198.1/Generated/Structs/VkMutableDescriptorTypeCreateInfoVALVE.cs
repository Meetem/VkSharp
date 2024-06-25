using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMutableDescriptorTypeCreateInfoVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public uint mutableDescriptorTypeListCount;
        public VkMutableDescriptorTypeListVALVE* pMutableDescriptorTypeLists;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMutableDescriptorTypeCreateInfoVALVE Create()
        {
            VkMutableDescriptorTypeCreateInfoVALVE ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
