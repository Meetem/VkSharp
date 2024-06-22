using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceSchedulingControlsFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 schedulingControls;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_FEATURES_ARM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceSchedulingControlsFeaturesARM Create()
        {
            VkPhysicalDeviceSchedulingControlsFeaturesARM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
