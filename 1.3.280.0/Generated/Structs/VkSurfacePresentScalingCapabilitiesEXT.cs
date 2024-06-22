using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSurfacePresentScalingCapabilitiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPresentScalingFlagsEXT supportedPresentScaling;
        public VkPresentGravityFlagsEXT supportedPresentGravityX;
        public VkPresentGravityFlagsEXT supportedPresentGravityY;
        public VkExtent2D minScaledImageExtent;
        public VkExtent2D maxScaledImageExtent;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSurfacePresentScalingCapabilitiesEXT Create()
        {
            VkSurfacePresentScalingCapabilitiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
