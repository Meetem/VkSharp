using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayTracingPipeline;
        public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplay;
        public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
        public VkBool32 rayTracingPipelineTraceRaysIndirect;
        public VkBool32 rayTraversalPrimitiveCulling;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceRayTracingPipelineFeaturesKHR Create()
        {
            VkPhysicalDeviceRayTracingPipelineFeaturesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
