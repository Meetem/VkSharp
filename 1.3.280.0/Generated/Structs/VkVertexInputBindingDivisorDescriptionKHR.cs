using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVertexInputBindingDivisorDescriptionKHR
    {
        public uint binding;
        public uint divisor;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVertexInputBindingDivisorDescriptionKHR Create()
        {
            return default;
        }
        
    }
}
