using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAttachmentSampleCountInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public uint colorAttachmentCount;
        public VkSampleCountFlags* pColorAttachmentSamples;
        public VkSampleCountFlags depthStencilAttachmentSamples;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAttachmentSampleCountInfoAMD Create()
        {
            VkAttachmentSampleCountInfoAMD ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
