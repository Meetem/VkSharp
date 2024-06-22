using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorBufferBindingInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong address;
        public VkBufferUsageFlags usage;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorBufferBindingInfoEXT Create()
        {
            VkDescriptorBufferBindingInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
