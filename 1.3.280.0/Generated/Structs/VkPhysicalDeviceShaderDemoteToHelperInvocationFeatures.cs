using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderDemoteToHelperInvocation;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures Create()
        {
            VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
