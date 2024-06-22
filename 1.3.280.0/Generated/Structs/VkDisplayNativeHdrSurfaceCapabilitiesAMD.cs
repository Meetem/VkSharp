using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 localDimmingSupport;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDisplayNativeHdrSurfaceCapabilitiesAMD Create()
        {
            VkDisplayNativeHdrSurfaceCapabilitiesAMD ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
