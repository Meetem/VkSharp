using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMaintenance6PropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 blockTexelViewCompatibleMultipleLayers;
        public uint maxCombinedImageSamplerDescriptorCount;
        public VkBool32 fragmentShadingRateClampCombinerInputs;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMaintenance6PropertiesKHR Create()
        {
            return default;
        }
        
    }
}
