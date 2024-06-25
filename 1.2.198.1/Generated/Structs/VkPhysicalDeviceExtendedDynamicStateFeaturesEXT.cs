using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 extendedDynamicState;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceExtendedDynamicStateFeaturesEXT Create()
        {
            VkPhysicalDeviceExtendedDynamicStateFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
