using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 clusterShadingRate;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_VRS_FEATURES_HUAWEI;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI Create()
        {
            VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
