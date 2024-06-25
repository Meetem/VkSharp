using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceVulkan11Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte deviceUUID[16];
        public fixed byte driverUUID[16];
        public fixed byte deviceLUID[8];
        public uint deviceNodeMask;
        public VkBool32 deviceLUIDValid;
        public uint subgroupSize;
        public VkShaderStageFlags subgroupSupportedStages;
        public VkSubgroupFeatureFlags subgroupSupportedOperations;
        public VkBool32 subgroupQuadOperationsInAllStages;
        public VkPointClippingBehavior pointClippingBehavior;
        public uint maxMultiviewViewCount;
        public uint maxMultiviewInstanceIndex;
        public VkBool32 protectedNoFault;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceVulkan11Properties Create()
        {
            return default;
        }
        
    }
}
