using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderCoreBuiltins;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM Create()
        {
            VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
