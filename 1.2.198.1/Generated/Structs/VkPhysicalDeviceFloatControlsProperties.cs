using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceFloatControlsProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public VkShaderFloatControlsIndependence roundingModeIndependence;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
        public VkBool32 shaderDenormPreserveFloat16;
        public VkBool32 shaderDenormPreserveFloat32;
        public VkBool32 shaderDenormPreserveFloat64;
        public VkBool32 shaderDenormFlushToZeroFloat16;
        public VkBool32 shaderDenormFlushToZeroFloat32;
        public VkBool32 shaderDenormFlushToZeroFloat64;
        public VkBool32 shaderRoundingModeRTEFloat16;
        public VkBool32 shaderRoundingModeRTEFloat32;
        public VkBool32 shaderRoundingModeRTEFloat64;
        public VkBool32 shaderRoundingModeRTZFloat16;
        public VkBool32 shaderRoundingModeRTZFloat32;
        public VkBool32 shaderRoundingModeRTZFloat64;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceFloatControlsProperties Create()
        {
            VkPhysicalDeviceFloatControlsProperties ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
