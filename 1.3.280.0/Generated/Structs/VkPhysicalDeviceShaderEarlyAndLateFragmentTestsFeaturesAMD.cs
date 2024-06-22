using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderEarlyAndLateFragmentTests;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_FEATURES_AMD;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD Create()
        {
            VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
