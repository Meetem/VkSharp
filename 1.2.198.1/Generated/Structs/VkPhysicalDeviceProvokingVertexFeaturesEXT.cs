using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceProvokingVertexFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 provokingVertexLast;
        public VkBool32 transformFeedbackPreservesProvokingVertex;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceProvokingVertexFeaturesEXT Create()
        {
            VkPhysicalDeviceProvokingVertexFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
