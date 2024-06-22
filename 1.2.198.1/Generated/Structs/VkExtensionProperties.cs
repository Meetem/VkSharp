using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkExtensionProperties
    {
        public fixed byte extensionName[256];
        public uint specVersion;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkExtensionProperties Create()
        {
            return default;
        }
        
    }
}
