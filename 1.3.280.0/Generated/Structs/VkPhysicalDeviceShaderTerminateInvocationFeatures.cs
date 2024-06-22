using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderTerminateInvocationFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderTerminateInvocation;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderTerminateInvocationFeatures Create()
        {
            VkPhysicalDeviceShaderTerminateInvocationFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
