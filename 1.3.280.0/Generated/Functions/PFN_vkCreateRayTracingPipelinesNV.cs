using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateRayTracingPipelinesNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, in VkAllocationCallbacks, ref VkPipeline, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, in VkAllocationCallbacks, ref VkPipeline, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateRayTracingPipelinesNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, in VkAllocationCallbacks, ref VkPipeline, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateRayTracingPipelinesNV(delegate *unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, in VkAllocationCallbacks, ref VkPipeline, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateRayTracingPipelinesNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateRayTracingPipelinesNV(VkFunctionPointer v) => new PFN_vkCreateRayTracingPipelinesNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateRayTracingPipelinesNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateRayTracingPipelinesNV(void* v) => new PFN_vkCreateRayTracingPipelinesNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkPipeline pPipelines)
        {
            return this.ptr(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator, ref pPipelines);
        }
    }
}
