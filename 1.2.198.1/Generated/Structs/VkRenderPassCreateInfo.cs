using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassCreateFlags flags;
        public uint attachmentCount;
        public VkAttachmentDescription* pAttachments;
        public uint subpassCount;
        public VkSubpassDescription* pSubpasses;
        public uint dependencyCount;
        public VkSubpassDependency* pDependencies;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassCreateInfo Create()
        {
            VkRenderPassCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
