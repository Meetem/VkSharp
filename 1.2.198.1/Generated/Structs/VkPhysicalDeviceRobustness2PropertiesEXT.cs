using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceRobustness2PropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong robustStorageBufferAccessSizeAlignment;
        public ulong robustUniformBufferAccessSizeAlignment;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceRobustness2PropertiesEXT Create()
        {
            return default;
        }
        
    }
}
