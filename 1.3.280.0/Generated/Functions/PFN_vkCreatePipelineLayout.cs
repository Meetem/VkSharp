using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreatePipelineLayout : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineLayoutCreateInfo, in VkAllocationCallbacks, ref VkPipelineLayout, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineLayoutCreateInfo, in VkAllocationCallbacks, ref VkPipelineLayout, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreatePipelineLayout(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineLayoutCreateInfo, in VkAllocationCallbacks, ref VkPipelineLayout, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreatePipelineLayout(delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineLayoutCreateInfo, in VkAllocationCallbacks, ref VkPipelineLayout, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreatePipelineLayout v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreatePipelineLayout(VkFunctionPointer v) => new PFN_vkCreatePipelineLayout(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreatePipelineLayout v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreatePipelineLayout(void* v) => new PFN_vkCreatePipelineLayout(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkPipelineLayoutCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkPipelineLayout pPipelineLayout)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pPipelineLayout);
        }
    }
}
