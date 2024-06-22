using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceGeneratedCompute;
        public VkBool32 deviceGeneratedComputePipelines;
        public VkBool32 deviceGeneratedComputeCaptureReplay;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_COMPUTE_FEATURES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV Create()
        {
            VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
