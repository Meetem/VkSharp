using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderTileImageFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderTileImageColorReadAccess;
        public VkBool32 shaderTileImageDepthReadAccess;
        public VkBool32 shaderTileImageStencilReadAccess;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderTileImageFeaturesEXT Create()
        {
            VkPhysicalDeviceShaderTileImageFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
