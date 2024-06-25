using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateCudaFunctionNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkCudaFunctionCreateInfoNV, in VkAllocationCallbacks, ref VkCudaFunctionNV, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCudaFunctionCreateInfoNV, in VkAllocationCallbacks, ref VkCudaFunctionNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateCudaFunctionNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCudaFunctionCreateInfoNV, in VkAllocationCallbacks, ref VkCudaFunctionNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateCudaFunctionNV(delegate *unmanaged[Cdecl]<VkDevice, in VkCudaFunctionCreateInfoNV, in VkAllocationCallbacks, ref VkCudaFunctionNV, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateCudaFunctionNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateCudaFunctionNV(VkFunctionPointer v) => new PFN_vkCreateCudaFunctionNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateCudaFunctionNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateCudaFunctionNV(void* v) => new PFN_vkCreateCudaFunctionNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkCudaFunctionCreateInfoNV pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkCudaFunctionNV pFunction)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pFunction);
        }
    }
}
