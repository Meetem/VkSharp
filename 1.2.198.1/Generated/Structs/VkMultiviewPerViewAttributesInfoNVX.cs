using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMultiviewPerViewAttributesInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 perViewAttributes;
        public VkBool32 perViewAttributesPositionXOnly;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMultiviewPerViewAttributesInfoNVX Create()
        {
            VkMultiviewPerViewAttributesInfoNVX ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
