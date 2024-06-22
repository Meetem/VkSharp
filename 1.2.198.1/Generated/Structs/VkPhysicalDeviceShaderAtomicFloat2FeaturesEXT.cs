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
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T GetNextRef<T>(out bool isNull)
        	where T: unmanaged
        {
            isNull = pNext == null;
            return ref VkUnsafe.PtrToRef<T>(pNext);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T* GetNext<T>()
        	where T: unmanaged
        {
            return (T*)pNext;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetNext<T>(ref T next)
        	where T: unmanaged
        {
            pNext = VkUnsafe.RefToPtr<T>(ref next);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetNextNull()
        {
            pNext = null;
        }
    }
}
