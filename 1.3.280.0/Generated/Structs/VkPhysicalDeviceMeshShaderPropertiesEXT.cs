using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxTaskWorkGroupTotalCount;
        public fixed uint maxTaskWorkGroupCount[3];
        public uint maxTaskWorkGroupInvocations;
        public fixed uint maxTaskWorkGroupSize[3];
        public uint maxTaskPayloadSize;
        public uint maxTaskSharedMemorySize;
        public uint maxTaskPayloadAndSharedMemorySize;
        public uint maxMeshWorkGroupTotalCount;
        public fixed uint maxMeshWorkGroupCount[3];
        public uint maxMeshWorkGroupInvocations;
        public fixed uint maxMeshWorkGroupSize[3];
        public uint maxMeshSharedMemorySize;
        public uint maxMeshPayloadAndSharedMemorySize;
        public uint maxMeshOutputMemorySize;
        public uint maxMeshPayloadAndOutputMemorySize;
        public uint maxMeshOutputComponents;
        public uint maxMeshOutputVertices;
        public uint maxMeshOutputPrimitives;
        public uint maxMeshOutputLayers;
        public uint maxMeshMultiviewViewCount;
        public uint meshOutputPerVertexGranularity;
        public uint meshOutputPerPrimitiveGranularity;
        public uint maxPreferredTaskWorkGroupInvocations;
        public uint maxPreferredMeshWorkGroupInvocations;
        public VkBool32 prefersLocalInvocationVertexOutput;
        public VkBool32 prefersLocalInvocationPrimitiveOutput;
        public VkBool32 prefersCompactVertexOutput;
        public VkBool32 prefersCompactPrimitiveOutput;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMeshShaderPropertiesEXT Create()
        {
            VkPhysicalDeviceMeshShaderPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
