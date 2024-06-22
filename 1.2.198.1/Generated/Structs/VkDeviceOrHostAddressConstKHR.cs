using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkDeviceOrHostAddressConstKHR
    {
        [FieldOffset(0)]
        public ulong deviceAddress;
        [FieldOffset(0)]
        public void* hostAddress;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceOrHostAddressConstKHR Create()
        {
            return default;
        }
        
    }
}
