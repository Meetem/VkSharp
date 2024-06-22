using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSurfacePresentModeCompatibilityEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint presentModeCount;
        public VkPresentModeKHR* pPresentModes;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSurfacePresentModeCompatibilityEXT Create()
        {
            VkSurfacePresentModeCompatibilityEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
