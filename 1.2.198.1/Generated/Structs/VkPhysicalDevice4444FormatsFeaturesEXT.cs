using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDevice4444FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 formatA4R4G4B4;
        public VkBool32 formatA4B4G4R4;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDevice4444FormatsFeaturesEXT Create()
        {
            return default;
        }
        
    }
}
