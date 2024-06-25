using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderDemoteToHelperInvocation;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT Create()
        {
            VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
