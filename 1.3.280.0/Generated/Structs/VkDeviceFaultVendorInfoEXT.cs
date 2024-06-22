using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceFaultVendorInfoEXT
    {
        public fixed byte description[256];
        public ulong vendorFaultCode;
        public ulong vendorFaultData;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceFaultVendorInfoEXT Create()
        {
            return default;
        }
        
    }
}
