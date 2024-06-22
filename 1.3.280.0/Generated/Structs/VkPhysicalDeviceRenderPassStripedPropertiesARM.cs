using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceRenderPassStripedPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D renderPassStripeGranularity;
        public uint maxRenderPassStripes;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_PROPERTIES_ARM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceRenderPassStripedPropertiesARM Create()
        {
            VkPhysicalDeviceRenderPassStripedPropertiesARM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
