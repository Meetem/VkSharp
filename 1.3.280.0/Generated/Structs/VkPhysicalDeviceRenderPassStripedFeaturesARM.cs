using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceRenderPassStripedFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 renderPassStriped;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_FEATURES_ARM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceRenderPassStripedFeaturesARM Create()
        {
            VkPhysicalDeviceRenderPassStripedFeaturesARM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
