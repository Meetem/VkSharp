using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetAccelerationStructureBuildSizesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, in VkAccelerationStructureBuildGeometryInfoKHR, in uint, ref VkAccelerationStructureBuildSizesInfoKHR, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, in VkAccelerationStructureBuildGeometryInfoKHR, in uint, ref VkAccelerationStructureBuildSizesInfoKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetAccelerationStructureBuildSizesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, in VkAccelerationStructureBuildGeometryInfoKHR, in uint, ref VkAccelerationStructureBuildSizesInfoKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetAccelerationStructureBuildSizesKHR(delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, in VkAccelerationStructureBuildGeometryInfoKHR, in uint, ref VkAccelerationStructureBuildSizesInfoKHR, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetAccelerationStructureBuildSizesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetAccelerationStructureBuildSizesKHR(VkFunctionPointer v) => new PFN_vkGetAccelerationStructureBuildSizesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetAccelerationStructureBuildSizesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetAccelerationStructureBuildSizesKHR(void* v) => new PFN_vkGetAccelerationStructureBuildSizesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, in VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, in uint pMaxPrimitiveCounts, ref VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
        {
            this.ptr(device, buildType, in pBuildInfo, in pMaxPrimitiveCounts, ref pSizeInfo);
        }
    }
}
