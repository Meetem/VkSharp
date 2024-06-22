using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMultiDrawInfoEXT
    {
        public uint firstVertex;
        public uint vertexCount;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMultiDrawInfoEXT Create()
        {
            return default;
        }
        
    }
}
