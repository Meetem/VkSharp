using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkBuildAccelerationStructuresKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkBuildAccelerationStructuresKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkBuildAccelerationStructuresKHR(delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkBuildAccelerationStructuresKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkBuildAccelerationStructuresKHR(VkFunctionPointer v) => new PFN_vkBuildAccelerationStructuresKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkBuildAccelerationStructuresKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkBuildAccelerationStructuresKHR(void* v) => new PFN_vkBuildAccelerationStructuresKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            return this.ptr(device, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);
        }
    }
}
