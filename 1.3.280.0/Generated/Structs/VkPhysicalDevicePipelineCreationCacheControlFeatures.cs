using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDevicePipelineCreationCacheControlFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineCreationCacheControl;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDevicePipelineCreationCacheControlFeatures Create()
        {
            VkPhysicalDevicePipelineCreationCacheControlFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
