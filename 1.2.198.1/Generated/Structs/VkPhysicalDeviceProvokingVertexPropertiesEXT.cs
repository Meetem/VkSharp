using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceProvokingVertexPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 provokingVertexModePerPipeline;
        public VkBool32 transformFeedbackPreservesTriangleFanProvokingVertex;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceProvokingVertexPropertiesEXT Create()
        {
            VkPhysicalDeviceProvokingVertexPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
