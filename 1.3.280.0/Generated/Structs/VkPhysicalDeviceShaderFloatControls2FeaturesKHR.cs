using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderFloatControls2FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderFloatControls2;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderFloatControls2FeaturesKHR Create()
        {
            return default;
        }
        
    }
}
