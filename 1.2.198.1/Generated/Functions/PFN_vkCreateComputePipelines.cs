using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateComputePipelines : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, in VkAllocationCallbacks, ref VkPipeline, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, in VkAllocationCallbacks, ref VkPipeline, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateComputePipelines(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, in VkAllocationCallbacks, ref VkPipeline, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateComputePipelines(delegate *unmanaged[Cdecl]<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, in VkAllocationCallbacks, ref VkPipeline, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateComputePipelines v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateComputePipelines(VkFunctionPointer v) => new PFN_vkCreateComputePipelines(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateComputePipelines v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateComputePipelines(void* v) => new PFN_vkCreateComputePipelines(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkPipeline pPipelines)
        {
            return this.ptr(device, pipelineCache, createInfoCount, pCreateInfos, in pAllocator, ref pPipelines);
        }
    }
}
