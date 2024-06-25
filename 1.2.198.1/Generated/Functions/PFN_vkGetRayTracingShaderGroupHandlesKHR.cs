using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetRayTracingShaderGroupHandlesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, ulong, void*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, ulong, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetRayTracingShaderGroupHandlesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, ulong, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetRayTracingShaderGroupHandlesKHR(delegate *unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, ulong, void*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetRayTracingShaderGroupHandlesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetRayTracingShaderGroupHandlesKHR(VkFunctionPointer v) => new PFN_vkGetRayTracingShaderGroupHandlesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetRayTracingShaderGroupHandlesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetRayTracingShaderGroupHandlesKHR(void* v) => new PFN_vkGetRayTracingShaderGroupHandlesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, ulong dataSize, void* pData)
        {
            return this.ptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
    }
}
