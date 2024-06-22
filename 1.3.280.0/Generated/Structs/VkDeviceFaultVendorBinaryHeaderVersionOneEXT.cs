using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
    {
        public uint headerSize;
        public VkDeviceFaultVendorBinaryHeaderVersionEXT headerVersion;
        public uint vendorID;
        public uint deviceID;
        public uint driverVersion;
        public fixed byte pipelineCacheUUID[16];
        public uint applicationNameOffset;
        public uint applicationVersion;
        public uint engineNameOffset;
        public uint engineVersion;
        public uint apiVersion;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceFaultVendorBinaryHeaderVersionOneEXT Create()
        {
            return default;
        }
        
    }
}
