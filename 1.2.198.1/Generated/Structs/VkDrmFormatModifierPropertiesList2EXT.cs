using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDrmFormatModifierPropertiesList2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDrmFormatModifierPropertiesList2EXT Create()
        {
            return default;
        }
        
    }
}
