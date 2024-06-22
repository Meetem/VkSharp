using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceDepthBiasControlFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 depthBiasControl;
        public VkBool32 leastRepresentableValueForceUnormRepresentation;
        public VkBool32 floatRepresentation;
        public VkBool32 depthBiasExact;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_BIAS_CONTROL_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceDepthBiasControlFeaturesEXT Create()
        {
            VkPhysicalDeviceDepthBiasControlFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
