using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkLatencySurfaceCapabilitiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint presentModeCount;
        public VkPresentModeKHR* pPresentModes;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_LATENCY_SURFACE_CAPABILITIES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkLatencySurfaceCapabilitiesNV Create()
        {
            VkLatencySurfaceCapabilitiesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
