using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkHeadlessSurfaceCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkHeadlessSurfaceCreateFlagsEXT flags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkHeadlessSurfaceCreateInfoEXT Create()
        {
            VkHeadlessSurfaceCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
