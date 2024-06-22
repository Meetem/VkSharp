using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 separateDepthStencilLayouts;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures Create()
        {
            VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
