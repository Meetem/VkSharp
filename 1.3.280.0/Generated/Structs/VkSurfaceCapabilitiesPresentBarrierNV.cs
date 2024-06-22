using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSurfaceCapabilitiesPresentBarrierNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentBarrierSupported;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSurfaceCapabilitiesPresentBarrierNV Create()
        {
            VkSurfaceCapabilitiesPresentBarrierNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
