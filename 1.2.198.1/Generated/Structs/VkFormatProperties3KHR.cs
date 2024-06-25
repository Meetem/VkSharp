using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkFormatProperties3KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormatFeatureFlags2KHR linearTilingFeatures;
        public VkFormatFeatureFlags2KHR optimalTilingFeatures;
        public VkFormatFeatureFlags2KHR bufferFeatures;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkFormatProperties3KHR Create()
        {
            return default;
        }
        
    }
}
