using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorGetInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorType type;
        public VkDescriptorDataEXT data;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_GET_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorGetInfoEXT Create()
        {
            VkDescriptorGetInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
