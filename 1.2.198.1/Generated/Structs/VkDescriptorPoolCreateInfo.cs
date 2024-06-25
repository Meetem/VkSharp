using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDescriptorPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorPoolCreateFlags flags;
        public uint maxSets;
        public uint poolSizeCount;
        public VkDescriptorPoolSize* pPoolSizes;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorPoolCreateInfo Create()
        {
            VkDescriptorPoolCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
