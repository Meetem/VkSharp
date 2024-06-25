using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVertexInputBindingDescription2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint binding;
        public uint stride;
        public VkVertexInputRate inputRate;
        public uint divisor;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVertexInputBindingDescription2EXT Create()
        {
            return default;
        }
        
    }
}
