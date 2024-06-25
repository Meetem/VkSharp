using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 extendedDynamicState2;
        public VkBool32 extendedDynamicState2LogicOp;
        public VkBool32 extendedDynamicState2PatchControlPoints;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceExtendedDynamicState2FeaturesEXT Create()
        {
            return default;
        }
        
    }
}
