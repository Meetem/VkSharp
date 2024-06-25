using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderSubgroupUniformControlFlow;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR Create()
        {
            VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
