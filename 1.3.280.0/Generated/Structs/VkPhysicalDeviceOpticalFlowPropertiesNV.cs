using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceOpticalFlowPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOpticalFlowGridSizeFlagsNV supportedOutputGridSizes;
        public VkOpticalFlowGridSizeFlagsNV supportedHintGridSizes;
        public VkBool32 hintSupported;
        public VkBool32 costSupported;
        public VkBool32 bidirectionalFlowSupported;
        public VkBool32 globalFlowSupported;
        public uint minWidth;
        public uint minHeight;
        public uint maxWidth;
        public uint maxHeight;
        public uint maxNumRegionsOfInterest;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceOpticalFlowPropertiesNV Create()
        {
            VkPhysicalDeviceOpticalFlowPropertiesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
