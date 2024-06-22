using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderIntegerDotProductFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderIntegerDotProduct;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderIntegerDotProductFeatures Create()
        {
            VkPhysicalDeviceShaderIntegerDotProductFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
