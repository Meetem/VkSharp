using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxDrawMeshTasksCount;
        public uint maxTaskWorkGroupInvocations;
        public fixed uint maxTaskWorkGroupSize[3];
        public uint maxTaskTotalMemorySize;
        public uint maxTaskOutputCount;
        public uint maxMeshWorkGroupInvocations;
        public fixed uint maxMeshWorkGroupSize[3];
        public uint maxMeshTotalMemorySize;
        public uint maxMeshOutputVertices;
        public uint maxMeshOutputPrimitives;
        public uint maxMeshMultiviewViewCount;
        public uint meshOutputPerVertexGranularity;
        public uint meshOutputPerPrimitiveGranularity;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMeshShaderPropertiesNV Create()
        {
            VkPhysicalDeviceMeshShaderPropertiesNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
