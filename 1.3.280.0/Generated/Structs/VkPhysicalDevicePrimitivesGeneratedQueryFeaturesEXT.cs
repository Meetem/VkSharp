using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 primitivesGeneratedQuery;
        public VkBool32 primitivesGeneratedQueryWithRasterizerDiscard;
        public VkBool32 primitivesGeneratedQueryWithNonZeroStreams;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT Create()
        {
            VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
