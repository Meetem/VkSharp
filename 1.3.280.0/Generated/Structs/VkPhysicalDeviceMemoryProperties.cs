using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMemoryProperties
    {
        public uint memoryTypeCount;
        public FixedArrayVkMemoryTypeSize32 memoryTypes;
        public uint memoryHeapCount;
        public FixedArrayVkMemoryHeapSize16 memoryHeaps;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMemoryProperties Create()
        {
            return default;
        }
        
    }
}
