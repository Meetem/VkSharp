using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdTraceRaysIndirectKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, ulong, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, ulong, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdTraceRaysIndirectKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, ulong, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdTraceRaysIndirectKHR(delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, in VkStridedDeviceAddressRegionKHR, ulong, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdTraceRaysIndirectKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdTraceRaysIndirectKHR(VkFunctionPointer v) => new PFN_vkCmdTraceRaysIndirectKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdTraceRaysIndirectKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdTraceRaysIndirectKHR(void* v) => new PFN_vkCmdTraceRaysIndirectKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, in VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, in VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, in VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, in VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            this.ptr(commandBuffer, in pRaygenShaderBindingTable, in pMissShaderBindingTable, in pHitShaderBindingTable, in pCallableShaderBindingTable, indirectDeviceAddress);
        }
    }
}
