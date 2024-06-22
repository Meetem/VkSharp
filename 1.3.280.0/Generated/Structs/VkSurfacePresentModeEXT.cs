using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSurfacePresentModeEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPresentModeKHR presentMode;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSurfacePresentModeEXT Create()
        {
            VkSurfacePresentModeEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
