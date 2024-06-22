using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkLayerSettingEXT
    {
        public byte* pLayerName;
        public byte* pSettingName;
        public VkLayerSettingTypeEXT type;
        public uint valueCount;
        public void* pValues;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkLayerSettingEXT Create()
        {
            return default;
        }
        
    }
}
