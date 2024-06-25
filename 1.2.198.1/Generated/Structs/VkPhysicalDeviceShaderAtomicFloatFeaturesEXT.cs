using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderBufferFloat32Atomics;
        public VkBool32 shaderBufferFloat32AtomicAdd;
        public VkBool32 shaderBufferFloat64Atomics;
        public VkBool32 shaderBufferFloat64AtomicAdd;
        public VkBool32 shaderSharedFloat32Atomics;
        public VkBool32 shaderSharedFloat32AtomicAdd;
        public VkBool32 shaderSharedFloat64Atomics;
        public VkBool32 shaderSharedFloat64AtomicAdd;
        public VkBool32 shaderImageFloat32Atomics;
        public VkBool32 shaderImageFloat32AtomicAdd;
        public VkBool32 sparseImageFloat32Atomics;
        public VkBool32 sparseImageFloat32AtomicAdd;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderAtomicFloatFeaturesEXT Create()
        {
            VkPhysicalDeviceShaderAtomicFloatFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
