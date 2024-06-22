using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 clustercullingShader;
        public VkBool32 multiviewClusterCullingShader;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI Create()
        {
            VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
