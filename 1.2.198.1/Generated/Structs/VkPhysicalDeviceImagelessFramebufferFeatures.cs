using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceImagelessFramebufferFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 imagelessFramebuffer;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceImagelessFramebufferFeatures Create()
        {
            VkPhysicalDeviceImagelessFramebufferFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
