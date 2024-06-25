using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetRayTracingCaptureReplayShaderGroupHandlesKHR : IVkFuncPtr
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
        public PFN_vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, ulong, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(delegate *unmanaged[Cdecl]<VkDevice, VkPipeline, uint, uint, ulong, void*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetRayTracingCaptureReplayShaderGroupHandlesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkFunctionPointer v) => new PFN_vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetRayTracingCaptureReplayShaderGroupHandlesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(void* v) => new PFN_vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, ulong dataSize, void* pData)
        {
            return this.ptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
    }
}
