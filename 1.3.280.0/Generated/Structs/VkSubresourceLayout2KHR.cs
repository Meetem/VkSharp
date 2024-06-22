using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSubresourceLayout2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubresourceLayout subresourceLayout;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSubresourceLayout2KHR Create()
        {
            return default;
        }
        
    }
}
