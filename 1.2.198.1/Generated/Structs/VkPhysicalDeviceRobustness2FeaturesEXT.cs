using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceRobustness2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 robustBufferAccess2;
        public VkBool32 robustImageAccess2;
        public VkBool32 nullDescriptor;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceRobustness2FeaturesEXT Create()
        {
            return default;
        }
        
    }
}
