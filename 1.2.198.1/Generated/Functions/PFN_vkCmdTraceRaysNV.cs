using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdTraceRaysNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdTraceRaysNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdTraceRaysNV(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdTraceRaysNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdTraceRaysNV(VkFunctionPointer v) => new PFN_vkCmdTraceRaysNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdTraceRaysNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdTraceRaysNV(void* v) => new PFN_vkCmdTraceRaysNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
        {
            this.ptr(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
        }
    }
}
