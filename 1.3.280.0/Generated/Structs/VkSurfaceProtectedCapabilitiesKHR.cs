using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSurfaceProtectedCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 supportsProtected;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSurfaceProtectedCapabilitiesKHR Create()
        {
            VkSurfaceProtectedCapabilitiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
