using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreatePipelineCache : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineCacheCreateInfo, in VkAllocationCallbacks, ref VkPipelineCache, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineCacheCreateInfo, in VkAllocationCallbacks, ref VkPipelineCache, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreatePipelineCache(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineCacheCreateInfo, in VkAllocationCallbacks, ref VkPipelineCache, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreatePipelineCache(delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineCacheCreateInfo, in VkAllocationCallbacks, ref VkPipelineCache, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreatePipelineCache v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreatePipelineCache(VkFunctionPointer v) => new PFN_vkCreatePipelineCache(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreatePipelineCache v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreatePipelineCache(void* v) => new PFN_vkCreatePipelineCache(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkPipelineCacheCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkPipelineCache pPipelineCache)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pPipelineCache);
        }
    }
}
