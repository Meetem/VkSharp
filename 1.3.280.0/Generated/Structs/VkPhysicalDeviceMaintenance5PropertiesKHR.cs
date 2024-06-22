using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMaintenance5PropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 earlyFragmentMultisampleCoverageAfterSampleCounting;
        public VkBool32 earlyFragmentSampleMaskTestBeforeSampleCounting;
        public VkBool32 depthStencilSwizzleOneSupport;
        public VkBool32 polygonModePointSize;
        public VkBool32 nonStrictSinglePixelWideLinesUseParallelogram;
        public VkBool32 nonStrictWideLinesUseParallelogram;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMaintenance5PropertiesKHR Create()
        {
            return default;
        }
        
    }
}
