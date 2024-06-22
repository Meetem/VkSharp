using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassCreationControlEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 disallowMerging;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassCreationControlEXT Create()
        {
            VkRenderPassCreationControlEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
