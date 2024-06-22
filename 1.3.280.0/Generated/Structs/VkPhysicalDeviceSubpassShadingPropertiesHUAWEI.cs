using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxSubpassShadingWorkgroupSizeAspectRatio;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceSubpassShadingPropertiesHUAWEI Create()
        {
            VkPhysicalDeviceSubpassShadingPropertiesHUAWEI ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
