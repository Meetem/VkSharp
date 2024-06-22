using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderFloat16Int8Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderFloat16;
        public VkBool32 shaderInt8;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderFloat16Int8Features Create()
        {
            VkPhysicalDeviceShaderFloat16Int8Features ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
