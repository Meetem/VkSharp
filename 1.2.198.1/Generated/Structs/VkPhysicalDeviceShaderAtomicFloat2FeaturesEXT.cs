using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderBufferFloat16Atomics;
        public VkBool32 shaderBufferFloat16AtomicAdd;
        public VkBool32 shaderBufferFloat16AtomicMinMax;
        public VkBool32 shaderBufferFloat32AtomicMinMax;
        public VkBool32 shaderBufferFloat64AtomicMinMax;
        public VkBool32 shaderSharedFloat16Atomics;
        public VkBool32 shaderSharedFloat16AtomicAdd;
        public VkBool32 shaderSharedFloat16AtomicMinMax;
        public VkBool32 shaderSharedFloat32AtomicMinMax;
        public VkBool32 shaderSharedFloat64AtomicMinMax;
        public VkBool32 shaderImageFloat32AtomicMinMax;
        public VkBool32 sparseImageFloat32AtomicMinMax;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT Create()
        {
            return default;
        }
        
    }
}
