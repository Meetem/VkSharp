using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdTraceRaysKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, uint, uint, uint, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, uint, uint, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdTraceRaysKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, uint, uint, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdTraceRaysKHR(delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, uint, uint, uint, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdTraceRaysKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdTraceRaysKHR(VkFunctionPointer v) => new PFN_vkCmdTraceRaysKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdTraceRaysKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdTraceRaysKHR(void* v) => new PFN_vkCmdTraceRaysKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, in VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, in VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, in VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, in VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            this.ptr(commandBuffer, in pRaygenShaderBindingTable, in pMissShaderBindingTable, in pHitShaderBindingTable, in pCallableShaderBindingTable, width, height, depth);
        }
    }
}
