using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayTracingMaintenance1;
        public VkBool32 rayTracingPipelineTraceRaysIndirect2;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR Create()
        {
            return default;
        }
        
    }
}
