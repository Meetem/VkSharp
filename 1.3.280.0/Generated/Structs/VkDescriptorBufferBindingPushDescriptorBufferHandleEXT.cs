using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorBufferBindingPushDescriptorBufferHandleEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_PUSH_DESCRIPTOR_BUFFER_HANDLE_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorBufferBindingPushDescriptorBufferHandleEXT Create()
        {
            VkDescriptorBufferBindingPushDescriptorBufferHandleEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
