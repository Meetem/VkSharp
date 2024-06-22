using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkLayerProperties
    {
        public fixed byte layerName[256];
        public uint specVersion;
        public uint implementationVersion;
        public fixed byte description[256];
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkLayerProperties Create()
        {
            return default;
        }
        
    }
}
