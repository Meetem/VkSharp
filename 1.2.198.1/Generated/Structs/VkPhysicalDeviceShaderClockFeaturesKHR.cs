using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderClockFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderSubgroupClock;
        public VkBool32 shaderDeviceClock;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderClockFeaturesKHR Create()
        {
            VkPhysicalDeviceShaderClockFeaturesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
