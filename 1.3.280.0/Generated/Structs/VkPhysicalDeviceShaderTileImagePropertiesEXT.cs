using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderTileImagePropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderTileImageCoherentReadAccelerated;
        public VkBool32 shaderTileImageReadSampleFromPixelRateInvocation;
        public VkBool32 shaderTileImageReadFromHelperInvocation;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderTileImagePropertiesEXT Create()
        {
            VkPhysicalDeviceShaderTileImagePropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
