using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDevicePointClippingProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPointClippingBehavior pointClippingBehavior;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDevicePointClippingProperties Create()
        {
            VkPhysicalDevicePointClippingProperties ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
