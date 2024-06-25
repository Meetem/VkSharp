using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorSetLayoutSupport
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 supported;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorSetLayoutSupport Create()
        {
            VkDescriptorSetLayoutSupport ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
