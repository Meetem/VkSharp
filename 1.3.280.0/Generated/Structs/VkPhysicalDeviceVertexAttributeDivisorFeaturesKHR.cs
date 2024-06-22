using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 vertexAttributeInstanceRateDivisor;
        public VkBool32 vertexAttributeInstanceRateZeroDivisor;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR Create()
        {
            VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
