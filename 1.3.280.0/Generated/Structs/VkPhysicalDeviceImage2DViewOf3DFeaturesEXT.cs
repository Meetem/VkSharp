using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 image2DViewOf3D;
        public VkBool32 sampler2DViewOf3D;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceImage2DViewOf3DFeaturesEXT Create()
        {
            return default;
        }
        
    }
}
