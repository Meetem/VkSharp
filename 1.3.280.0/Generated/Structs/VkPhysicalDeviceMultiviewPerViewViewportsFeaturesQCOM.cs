using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 multiviewPerViewViewports;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM Create()
        {
            VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
