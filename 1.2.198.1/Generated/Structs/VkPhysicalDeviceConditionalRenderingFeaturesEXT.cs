using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 conditionalRendering;
        public VkBool32 inheritedConditionalRendering;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceConditionalRenderingFeaturesEXT Create()
        {
            VkPhysicalDeviceConditionalRenderingFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
