using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceNestedCommandBufferFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 nestedCommandBuffer;
        public VkBool32 nestedCommandBufferRendering;
        public VkBool32 nestedCommandBufferSimultaneousUse;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceNestedCommandBufferFeaturesEXT Create()
        {
            VkPhysicalDeviceNestedCommandBufferFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
