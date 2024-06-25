using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceASTCDecodeFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 decodeModeSharedExponent;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceASTCDecodeFeaturesEXT Create()
        {
            return default;
        }
        
    }
}
