using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceMeshShaderFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 taskShader;
        public VkBool32 meshShader;
        public VkBool32 multiviewMeshShader;
        public VkBool32 primitiveFragmentShadingRateMeshShader;
        public VkBool32 meshShaderQueries;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceMeshShaderFeaturesEXT Create()
        {
            VkPhysicalDeviceMeshShaderFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
