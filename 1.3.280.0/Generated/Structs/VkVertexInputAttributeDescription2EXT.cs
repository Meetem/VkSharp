using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVertexInputAttributeDescription2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint location;
        public uint binding;
        public VkFormat format;
        public uint offset;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVertexInputAttributeDescription2EXT Create()
        {
            return default;
        }
        
    }
}
