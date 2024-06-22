using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed uint maxWorkGroupCount[3];
        public fixed uint maxWorkGroupSize[3];
        public uint maxOutputClusterCount;
        public ulong indirectBufferOffsetAlignment;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI Create()
        {
            VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
