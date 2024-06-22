using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPushDescriptorSetWithTemplateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorUpdateTemplate descriptorUpdateTemplate;
        public VkPipelineLayout layout;
        public uint set;
        public void* pData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPushDescriptorSetWithTemplateInfoKHR Create()
        {
            VkPushDescriptorSetWithTemplateInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
