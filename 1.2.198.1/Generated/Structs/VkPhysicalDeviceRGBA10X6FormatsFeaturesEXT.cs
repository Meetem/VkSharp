using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 formatRgba10x6WithoutYCbCrSampler;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT Create()
        {
            return default;
        }
        
    }
}
