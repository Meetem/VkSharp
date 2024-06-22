using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 accelerationStructure;
        public VkBool32 accelerationStructureCaptureReplay;
        public VkBool32 accelerationStructureIndirectBuild;
        public VkBool32 accelerationStructureHostCommands;
        public VkBool32 descriptorBindingAccelerationStructureUpdateAfterBind;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceAccelerationStructureFeaturesKHR Create()
        {
            VkPhysicalDeviceAccelerationStructureFeaturesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
