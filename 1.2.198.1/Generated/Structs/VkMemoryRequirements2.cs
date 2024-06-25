using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMemoryRequirements2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryRequirements memoryRequirements;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMemoryRequirements2 Create()
        {
            return default;
        }
        
    }
}
