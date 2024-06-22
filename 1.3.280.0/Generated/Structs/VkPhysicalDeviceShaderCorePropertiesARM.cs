using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint pixelRate;
        public uint texelRate;
        public uint fmaRate;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderCorePropertiesARM Create()
        {
            VkPhysicalDeviceShaderCorePropertiesARM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
