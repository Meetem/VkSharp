using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceImageProcessing2FeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 textureBlockMatch2;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceImageProcessing2FeaturesQCOM Create()
        {
            return default;
        }
        
    }
}
