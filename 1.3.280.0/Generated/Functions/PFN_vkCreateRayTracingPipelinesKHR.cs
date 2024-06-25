using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateRayTracingPipelinesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, in VkAllocationCallbacks, ref VkPipeline, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, in VkAllocationCallbacks, ref VkPipeline, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateRayTracingPipelinesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, in VkAllocationCallbacks, ref VkPipeline, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateRayTracingPipelinesKHR(delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, in VkAllocationCallbacks, ref VkPipeline, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateRayTracingPipelinesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateRayTracingPipelinesKHR(VkFunctionPointer v) => new PFN_vkCreateRayTracingPipelinesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateRayTracingPipelinesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateRayTracingPipelinesKHR(void* v) => new PFN_vkCreateRayTracingPipelinesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkPipeline pPipelines)
        {
            return this.ptr(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, in pAllocator, ref pPipelines);
        }
    }
}
