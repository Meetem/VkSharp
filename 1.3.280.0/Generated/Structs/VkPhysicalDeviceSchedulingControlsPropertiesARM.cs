using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceSchedulingControlsPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceSchedulingControlsFlagsARM schedulingControlsFlags;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_PROPERTIES_ARM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceSchedulingControlsPropertiesARM Create()
        {
            VkPhysicalDeviceSchedulingControlsPropertiesARM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
