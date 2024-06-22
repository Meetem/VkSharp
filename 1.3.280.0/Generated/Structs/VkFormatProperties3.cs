using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkFormatProperties3
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormatFeatureFlags2 linearTilingFeatures;
        public VkFormatFeatureFlags2 optimalTilingFeatures;
        public VkFormatFeatureFlags2 bufferFeatures;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkFormatProperties3 Create()
        {
            return default;
        }
        
    }
}
